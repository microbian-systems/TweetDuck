﻿using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace TweetDick.Configuration{
    class LockManager{
        private readonly string file;
        private FileStream lockStream;
        private Process lockingProcess;

        public LockManager(string file){
            this.file = file;
        }

        private bool CreateLockFile(){
            if (lockStream != null){
                throw new InvalidOperationException("Lock file already exists.");
            }

            try{
                lockStream = new FileStream(file,FileMode.Create,FileAccess.Write,FileShare.Read);

                byte[] id = BitConverter.GetBytes(Process.GetCurrentProcess().Id);
                lockStream.Write(id,0,id.Length);
                lockStream.Flush();

                if (lockingProcess != null){
                    lockingProcess.Close();
                    lockingProcess = null;
                }

                return true;
            }catch(Exception){
                if (lockStream != null){
                    lockStream.Close();
                    lockStream.Dispose();
                }

                return false;
            }
        }

        public bool Lock(){
            if (lockStream != null)return true;

            try{
                byte[] bytes = new byte[4];

                using(FileStream fileStream = new FileStream(file,FileMode.Open,FileAccess.Read,FileShare.ReadWrite)){
                    fileStream.Read(bytes,0,4);
                }

                int pid = BitConverter.ToInt32(bytes,0);

                try{
                    lockingProcess = Process.GetProcessById(pid);
                }catch(ArgumentException){}

                return lockingProcess == null && CreateLockFile();
            }catch(DirectoryNotFoundException){
                string dir = Path.GetDirectoryName(file);

                if (dir != null){
                    Directory.CreateDirectory(dir);
                    return CreateLockFile();
                }
            }catch(FileNotFoundException){
                return CreateLockFile();
            }catch(Exception e){
                return false;
            }

            return false;
        }

        public void Unlock(){
            if (lockStream != null){
                lockStream.Close();
                lockStream.Dispose();
                File.Delete(file);

                lockStream = null;
            }
        }

        public bool CloseLockingProcess(int timeout){
            if (lockingProcess != null){
                lockingProcess.CloseMainWindow();

                for(int waited = 0; waited < timeout && !lockingProcess.HasExited;){
                    lockingProcess.Refresh();

                    Thread.Sleep(100);
                    waited += 100;
                }

                if (lockingProcess.HasExited){
                    lockingProcess.Close();
                    lockingProcess = null;
                    return true;
                }
            }

            return false;
        }
    }
}