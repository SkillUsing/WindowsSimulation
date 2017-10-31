using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace dm
{
    public class MemoryApi
    {
        [DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
        public static extern bool ReadProcessMemory
        (
            IntPtr lpProcess,
            IntPtr lpBaseAddress,
            IntPtr lpBuffer,
            int nSize,
            IntPtr BytesRead
        );
        //打开进程    
        //kernel32.dll系统动态链接库    
        [DllImportAttribute("kernel32.dll", EntryPoint = "OpenProcess")]
        public static extern IntPtr OpenProcess
        (
            int iAccess,
            bool Handle,
            int ProcessID
        );
        //关闭句柄    
        [DllImport("kernel32.dll", EntryPoint = "CloseHandle")]
        private static extern void CloseHandle
        (
            IntPtr hObject
        );
        //写内存    
        [DllImportAttribute("kernel32.dll", EntryPoint = "WriteProcessMemory")]
        public static extern bool WriteProcessMemory
        (
            IntPtr lpProcess,
            IntPtr lpBaseAddress,
            int[] lpBuffer,
            int nSize,
            IntPtr BytesWrite


        );
        //写内存    
        [DllImportAttribute("kernel32.dll", EntryPoint = "WriteProcessMemory")]
        public static extern bool WriteProcessMemory
        (
            IntPtr lpProcess,
            IntPtr lpBaseAddress,
            byte[] lpBuffer,
            int nSize,
            IntPtr BytesWrite


        );
        //GetModuleHandle是获取一个应用程序或动态链接库的模块句柄。    
        [DllImport("kernel32")]
        public static extern IntPtr GetModuleHandle(string lpModuleName);


        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool VirtualProtectEx
        (
            //修改内存的句柄    
            IntPtr hProcess,
            //要修改的起始地址    
            IntPtr lpAddress,
            //页区域大小    
            int dwSize,
            //访问方式    
            int flNewProtect,
            //用于保护改变前的保护属性    
            ref IntPtr lpflOldProtect
        );




        //根据进程名获取PID    
        public static int GetPidByProcessName(string processName)
        {
            Process[] ArrayProcess = Process.GetProcessesByName(processName);
            foreach (Process pro in ArrayProcess)
            {
                return pro.Id;
            }
            return 0;
        }


        //读内存模块    
        public static IntPtr ReadModule(string ModuleName)
        {
            return GetModuleHandle(ModuleName);
        }


        //读取内存的值    
        public static int ReadMemoryValue(int baseAddress, string ProcessName)
        {
            try
            {
                byte[] buffer = new byte[4];
                IntPtr byteAddress = Marshal.UnsafeAddrOfPinnedArrayElement(buffer, 0);
                IntPtr hProcess = OpenProcess(0x1F0FFF, false, GetPidByProcessName(ProcessName));
                ReadProcessMemory(hProcess, (IntPtr)baseAddress, byteAddress, 4, IntPtr.Zero);
                CloseHandle(hProcess);
                return Marshal.ReadInt32(byteAddress);
            }
            catch
            {
                return 0;
            }
        }
        public static long ReadMemoryValue(long baseAddress, string ProcessName)
        {
            try
            {
                string temp = ((IntPtr)baseAddress).ToString("x");
                byte[] buffer = new byte[4];
                IntPtr byteAddress = Marshal.UnsafeAddrOfPinnedArrayElement(buffer, 0);
                IntPtr hProcess = OpenProcess(0x1F0FFF, false, GetPidByProcessName(ProcessName));
                ReadProcessMemory(hProcess, (IntPtr)baseAddress, byteAddress, 4, IntPtr.Zero);
                CloseHandle(hProcess);
                string ss = ((IntPtr)baseAddress).ToString("x");
                return Marshal.ReadInt32(byteAddress);
            }
            catch
            {
                return 0;
            }
        }
        #region 写内存方式    


        //写内存整数型 




        public static void WriteMemoryValue(IntPtr baseAddress, string ProcessName, int value)
        {
            //打开进程获得句柄  
            var hProcess = OpenProcess(0x1F0FFF, false, GetPidByProcessName(ProcessName));
            var data = new int[] { value };
            WriteProcessMemory(hProcess, baseAddress, data, 4, IntPtr.Zero);
            CloseHandle(hProcess);
        }


        //public static bool WriteMemoryValue(IntPtr baseAddress, IntPtr hProcess, int value)
        //{
        //    //IntPtr hProcess = OpenProcess(0x1F0FFF, false, GetPidByProcessName(ProcessName));
        //    var data = new[] { value };
        //    return WriteProcessMemory(baseAddress,hProcess, data, 4, IntPtr.Zero);
        //}


        //写内存字节型    
        public static void WriteMemoryValue(int baseAddress, string ProcessName, byte[] value)
        {
            //打开进程获得句柄  
            IntPtr hProcess = OpenProcess(0x1F0FFF, false, GetPidByProcessName(ProcessName));

            bool flag;
            //bool flag2;  
            IntPtr adds = (IntPtr)0x33;
            //flag2 = VirtualProtectEx(hProcess, (IntPtr)baseAddress, 4, 0x40, ref adds);  
            flag = WriteProcessMemory(hProcess, (IntPtr)baseAddress, value, value.Length, IntPtr.Zero);

            string temp = ((IntPtr)baseAddress).ToString("x");
            CloseHandle(hProcess);
        }
        #endregion

    }
}