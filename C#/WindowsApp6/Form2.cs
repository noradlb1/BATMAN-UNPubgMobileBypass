using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using LOGIN;
using Memory;
using Microsoft.VisualBasic;

namespace WindowsApp6
{

    public partial class Form2
    {

        private int x22, y;
        private Point newpoint = new Point();
        private string PID;
        private string file2 = @"C:\Windows\Resources\adb.exe";
        private string file3 = @"C:\Windows\Resources\AdbWinApi.dll";
        private string file6 = @"C:\Windows\System32\drivers\etc\hosts";
        private string file5 = @"C:\Windows\Resources\ProgramFiles.so";
        private string file7 = @"C:\Windows\Resources\Windows32.dll";

        public Form2()
        {
            InitializeComponent();
        }

        [DllImport("KERNEL32.DLL")]
        public static extern IntPtr CreateToolhelp32Snapshot(uint flags, uint processid);
        [DllImport("KERNEL32.DLL")]
        public static extern int Process32First(IntPtr handle, ref ProcessEntry32 pe);
        [DllImport("KERNEL32.DLL")]
        public static extern int Process32Next(IntPtr handle, ref ProcessEntry32 pe);
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            x22 = MousePosition.X - Location.X;
            y = MousePosition.Y - Location.Y;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();

        }
        private IntPtr method_0()
        {
            var intPtr = IntPtr.Zero;
            uint num = 0U;
            var intPtr2 = CreateToolhelp32Snapshot(2U, 0U);

            if ((int)intPtr2 > 0)
            {
                ProcessEntry32 processEntry = default;
                processEntry.dwSize = (uint)Marshal.SizeOf(processEntry);
                int num2 = Process32First(intPtr2, ref processEntry);

                while (num2 == 1)
                {
                    var intPtr3 = Marshal.AllocHGlobal((int)processEntry.dwSize);
                    Marshal.StructureToPtr(processEntry, intPtr3, true);
                    ProcessEntry32 processEntry2 = (ProcessEntry32)Marshal.PtrToStructure(intPtr3, typeof(ProcessEntry32));
                    Marshal.FreeHGlobal(intPtr3);
                    // AndroidProcess
                    if (processEntry2.szExeFile.Contains("aow_exe") && processEntry2.cntThreads > num)
                    {
                        num = processEntry2.cntThreads;
                        intPtr = (IntPtr)(long)(ulong)processEntry2.th32ProcessID;
                    }

                    num2 = Process32Next(intPtr2, ref processEntry);
                }

                PID = Convert.ToString(intPtr);


                // Thread.Sleep(1000)
                // MessageBox.Show(Label1.Text)

                Bypass();
                // create server
            }
            return intPtr;
        }
        private string sr;
        public void XtremeService()
        {

            string validchars = "abcdefghijklmnopqrstuvwxyz";
            var sb = new StringBuilder();
            var rand = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int idx = rand.Next(0, validchars.Length);
                char randomChar = validchars[idx];
                sb.Append(randomChar);
            }
            sr = sb.ToString();
            if (File.Exists(@"C:\" + sr + ".sys"))
            {
            }

            else
            {
                File.WriteAllBytes(@"C:\" + sr + ".sys", My.Resources.Resources.xtreme);


                var p1 = new Process();
                p1.StartInfo.FileName = "cmd.exe"; // jioUN0XmYd
                p1.StartInfo.Arguments = "/c sc create " + sr + @" binpath= C:\" + sr + ".sys start=demand type=filesys & net start " + sr; // & r
                p1.StartInfo.UseShellExecute = false;
                p1.StartInfo.CreateNoWindow = true;
                p1.Start();
                p1.WaitForExit();
            }
            x = 0;
            method_0();
            // End If
        }
        // Public Long enumerable = New Long();
        public long enumerable = new long();



        public async void Bypass()
        {
            IEnumerable<long> enumerable;
            // Me.Text = "bypassing"
            if (Convert.ToInt32(PID) == 0)
            {
                PID = "SmartGaGa Not Running";
                Close();
            }
            else
            {
                MemLib.OpenProcess(Convert.ToInt32(PID));
                enumerable = await MemLib.AoBScan("F0 4F 2D E9 1C B0 8D E2 24 D0 4D E2 00 A0 A0 E1 DC 04 9F E5 01 80 A0", false, false, "");
                // 1879048192L, 2415919104L, 

                string_0 = "0x" + enumerable.FirstOrDefault().ToString("X");
                Mem.MemoryProtection memoryProtection;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, out memoryProtection, "");
                // MsgBox(string_0)
                bool k = false;
                foreach (long num in enumerable)
                {
                    // MsgBox()
                    k = true;
                    // Form1.ListBox1.Items.Add(num.ToString("X"))
                    // Me.Text = num.ToString("X")
                    // MessageBox.Show(num.ToString("X"))
                    MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 A0 E3 1E FF 2F E1", "", null);
                    // Me.MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 A0 E3 1E FF 2F E1", "", Nothing)
                    // Me.MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 A0 E3 1E FF 2F E1", "", Nothing)


                }
                if (k == false)
                {
                    // Button1.Text = "BYPASS SUCCESSFULL"
                    x = 0;
                    Timer1.Enabled = true;
                }
                // Timer2.Enabled = True
                else
                {
                    // Label1.Text = "DONE" & x
                    x += 1;
                    Timer1.Enabled = true;
                }
                Mem.MemoryProtection memoryProtection2;
                MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadOnly, out memoryProtection2, "");
                // Me.Close()

            }
        }
        private int x;
        public Mem MemLib = new Mem();
        private static string string_0;
        private static string string_ANTI;
        private IContainer icontainer_0;
        public struct ProcessEntry32
        {
            public uint dwSize;

            public uint cntUsage;

            public uint th32ProcessID;

            public IntPtr th32DefaultHeapID;

            public uint th32ModuleID;

            public uint cntThreads;

            public uint th32ParentProcessID;

            public int pcPriClassBase;

            public uint dwFlags;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szExeFile;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (x == 3)
            {
                // done
                Label3.Text = "Bypass Done !!!";
                Timer2.Enabled = true;
            }
            else
            {
                method_0();
            }
            Timer1.Enabled = false;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c net stop " + sr;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.WaitForExit();
            File.Delete(@"C:\" + sr + ".sys");
            Timer2.Enabled = false;
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                ComboBox1.Text = "PID: " + Conversion.Hex(PID);
            }

            catch (Exception ex)
            {

            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                // IO.File.WriteAllBytes("C:\Windows\System32\drivers\etc\hosts", My.Resources.hosts)

                var process = new Process();
                process.StartInfo = new ProcessStartInfo() { FileName = "cmd.exe", CreateNoWindow = true, RedirectStandardInput = true, UseShellExecute = false };
                process.Start();
                using (var standardInput = process.StandardInput)
                {
                    bool flag = !standardInput.BaseStream.CanWrite;
                    if (!flag)
                    {
                        standardInput.WriteLine("NetSh Advfirewall set allprofiles state on");
                        standardInput.WriteLine("netsh advfirewall firewall add rule name=System dir=out remoteport=17000-18000,30000-35000,547,3013,10000,17500,35000,62448,14000,18018,7889,8000-8099 protocol=TCP action =block");
                        standardInput.WriteLine("netsh advfirewall firewall add rule name=System2 dir=out remoteport=10012,18081,13000-14000,15692 protocol=TCP action =block");
                        standardInput.WriteLine("netsh advfirewall firewall add rule name=System3 dir=out remoteport=10012 protocol=TCP action =block");
                    }
                }
            }

            else
            {
                var process = new Process();
                process.StartInfo = new ProcessStartInfo() { FileName = "cmd.exe", CreateNoWindow = true, RedirectStandardInput = true, UseShellExecute = false };
                process.Start();
                using (var standardInput = process.StandardInput)
                {
                    bool flag = !standardInput.BaseStream.CanWrite;
                    if (!flag)
                    {
                        standardInput.WriteLine("netsh advfirewall firewall delete rule name=" + "System");
                        standardInput.WriteLine("netsh advfirewall firewall delete rule name=" + "System2");
                        standardInput.WriteLine("netsh advfirewall firewall delete rule name=" + "System3");

                    }
                }
            }
        }
        public void L()
        {
            var process = new Process();
            process.StartInfo = new ProcessStartInfo() { FileName = "cmd.exe", CreateNoWindow = true, RedirectStandardInput = true, UseShellExecute = false };
            process.Start();
            using (var standardInput = process.StandardInput)
            {
                bool flag = !standardInput.BaseStream.CanWrite;
                if (!flag)
                {
                    standardInput.WriteLine("@echo off");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe kill-server");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe start-server");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe connect 127.0.0.1:5555");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /data/data/com.tencent.ig/databases/__hs__db_issues");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /data/data/com.tencent.ig/databases/__hs__db_key_values");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /data/data/com.tencent.ig/databases/__hs__db_properties");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /data/data/com.tencent.ig/databases/__hs_db_helpshift_users");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /data/data/com.tencent.ig/databases/beacon_db");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /data/data/com.tencent.ig/databases/bugly_db_");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /data/data/com.tencent.ig/databases/config.db");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /data/data/com.tencent.ig/databases/iMSDK.db");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks/puffer_temp");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks/1375135419_47_0.14.5.11182_20190913173659_1446534324_cures.ifs.res");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks/filelist.json");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks/puffer_res.eifs");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks/PufferFileList.json");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks/apollo_reslist.flist");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Tencent");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/cache");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/ca-bundle.pem");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/tbslog");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/login-identifier.txt");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/cacheFile.txt");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/vmpcloudconfig.json");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Logs");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/RoleInfo/RoleInfo.json");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/UpdateInfo");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/ImageDownload");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Pandora");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/Engine");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/StatEventReportedFlag");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/PufferTmpDir");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/app_appcache");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/app_bugly");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/app_crashrecord");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/cache");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/code_cache");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/files/iMSDK");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/files/ss_tmp");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/files/tss_tmp");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/files/AppEventsLogger.persistedevents");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/files/tpnlcache.data");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/files/tss_app_915c.dat");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/files/tss_cs_stat2.dat");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/files/tss.i.m.dat");
                    standardInput.WriteLine(@"C:\Windows\Resources\adb.exe kill-server");
                }
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            L();

            if (CheckBox1.Checked == true)
            {
                var process = new Process();
                process.StartInfo = new ProcessStartInfo() { FileName = "cmd.exe", CreateNoWindow = true, RedirectStandardInput = true, UseShellExecute = false };
                process.Start();
                using (var standardInput = process.StandardInput)
                {
                    bool flag = !standardInput.BaseStream.CanWrite;
                    if (!flag)
                    {
                        standardInput.WriteLine("NetSh Advfirewall set allprofiles state on");
                        standardInput.WriteLine("netsh advfirewall firewall add rule name=chrome dir=out remoteport=17000-17499,17501-18000,30000-34560,547,3013,10000-10050,34590-35000,62448,14000,18018,7889,8000-8099 protocol=TCP action =block");
                    }
                }
                // Process.Start("C:\\Windows\\Help\\Windows\\IndexStore\\System.CT")
                XtremeService();
            }

            else
            {
                // '
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                KillProcess("ProjectTitan");
            }
            catch (Exception ex)
            {
            }



            try
            {
                KillProcess("adb");
            }
            catch (Exception ex)
            {

            }

            File.WriteAllBytes(file2, My.Resources.Resources.adb);

            File.WriteAllBytes(file5, My.Resources.Resources.ProgramFiles);
            File.WriteAllBytes(file7, My.Resources.Resources.Windows32);
            File.WriteAllBytes(file3, My.Resources.Resources.AdbWinApi);

            // IO.File.SetAttributes("C:\\Windows\\Resources\\adb.exe", IO.FileAttributes.Hidden)
            // IO.File.SetAttributes("C:\Windows\Resources\AdbWinApi.dll", IO.FileAttributes.Hidden)

            try
            {
                File.Delete(@"C:\Windows\System32\drivers\etc\hosts");
            }
            catch (Exception ex)
            {

            }

            // Dim fs As FileSystemSecurity = File.GetAccessControl("C:\Windows\Resources")
            // fs.AddAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
            // File.SetAccessControl("C:\Windows\Resources", fs)


            // Process.Start(IO.Path.Combine(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\SmartGaGa\ProjectTitan", Nothing), ""))
            // Process.Start(IO.Path.Combine(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Tencent\MobileGamePC\UI", "InstallPath", Nothing), "AndroidEmulator.exe"))]
            Process.Start(@"D:\WindowsFormsApp7\WindowsFormsApp7\Resources\ui\AndroidEmulator.exe");
        }
        public void GL()
        {
            var process = new Process();
            process.StartInfo = new ProcessStartInfo() { FileName = "cmd.exe", CreateNoWindow = true, RedirectStandardInput = true, UseShellExecute = false };
            process.Start();
            using (var standardInput = process.StandardInput)
            {
                bool flag = !standardInput.BaseStream.CanWrite;
                if (!flag)
                {
                    // standardInput.WriteLine("NetSh Advfirewall set allprofiles state on")
                    // standardInput.WriteLine("netsh advfirewall firewall add rule name=chrome dir=out remoteport=17000-17499,17501-18000,30000-34560,547,3013,10000-10050,34590-35000,62448,14000,18018,7889,8000-8099 protocol=TCP action =block")
                    standardInput.WriteLine("@echo off");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe kill-server");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe start-server");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe connect 127.0.0.1:5555");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/files/tss_tmp/*");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/cache/*");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/app_bugly/*");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/files/iMSDK/*");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/databases");
                    standardInput.WriteLine("cls");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell rm -rf /system/bin/disable_houdini");
                    standardInput.WriteLine("cls");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell rm -rf /system/bin/enable_houdini");
                    standardInput.WriteLine("cls");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell rm -rf /system/bin/houdini");
                    standardInput.WriteLine("cls");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell rm -rf /system/libs/libldutils.so");
                    standardInput.WriteLine("cls");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /data/data/com.tencent.ig/files");
                    standardInput.WriteLine("cls");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /data/data/com.tencent.ig/files/tss_tmp");
                    standardInput.WriteLine("cls");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /data/data/com.tencent.ig/app_bugly");
                    standardInput.WriteLine("cls");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /data/data/com.tencent.ig/cache");
                    standardInput.WriteLine("cls");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 444 /data/data/com.tencent.ig/files/iMSDK");
                    standardInput.WriteLine("cls");
                    // standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 push C:\\Windows\\Resources\\ProgramFiles.so /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks/game_patch_1.0.0.14361.pak")
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell rm -r /system/lib/libhoudini_415c.so");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 push C:\\Windows\\Resources\\Windows32.dll /system/lib/libhoudini_415c.so");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell am start -n com.tencent.ig/com.epicgames.ue4.SplashActivity");
                    // standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell mv /system/lib/libhoudini_408p.so /system/lib/libhoudini_408p.txt")
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell mv /init.vbox86.rc /init.vbox86.r0");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /system/lib/libhardware.so");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /system/lib/libbcinfo.so");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /system/lib/libandroid.so");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe kill-server");


                }
            }

        }
        public void KillProcess(string processName)
        {
            Process[] procs = Process.GetProcesses();
            foreach (Process prc in procs)
            {
                if ((prc.ProcessName ?? "") == (processName ?? ""))
                {
                    prc.Kill();
                }
            }

        }
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;

            try
            {
                File.Delete(@"C:\Windows\System32\drivers\etc\hosts");
            }
            catch (Exception ex)
            {

            }
            KillProcess("adb");
            var process = new Process();
            process.StartInfo = new ProcessStartInfo() { FileName = "cmd.exe", CreateNoWindow = true, RedirectStandardInput = true, UseShellExecute = false };
            process.Start();
            using (var standardInput = process.StandardInput)
            {
                bool flag = !standardInput.BaseStream.CanWrite;
                if (!flag)
                {
                    standardInput.WriteLine("netsh advfirewall firewall delete rule name=" + "chrome");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe   kill-server");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe   start-server");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe   connect 127.0.0.1:5555");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell am kill com.tencent.ig");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell am force-stop com.tencent.ig");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell am kill com.rekoo.pubgm");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell am force-stop com.rekoo.pubgm");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell am kill com.pubg.krmobile");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell am force-stop com.pubg.krmobile");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell mv /system/lib/libhoudini_408p.txt /system/lib/libhoudini_408p.so");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell mv /system/lib/libhoudini_415c.txt /system/lib/libhoudini_415c.so");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell mv /init.vbox86.r0 /init.vbox86.rc");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /system/priv-app/Settings.apk");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /system/priv-app/Settings.apk");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /system/priv-app/SystemUI.apk");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /system/priv-app/Superuser.apk");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /system/app/tinput.apk");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /system/priv-app/");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 750 /init.rc");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 750 /init.superuser.rc");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 750 /ueventd.vbox86.rc");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 750 /init.environ.rc");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 755 /system/bin/androVM_setprop");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /system/lib/libandroid.so");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /system/lib/libhardware.so");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /system/lib/hw/gralloc.vbox86.so");
                    standardInput.WriteLine("TaskKill /F /IM appmarket.exe");
                    standardInput.WriteLine("TaskKill /F /IM AndroidEmulator.exe");
                    standardInput.WriteLine(@"C:\\Windows\\Resources\\adb.exe kill-server");
                }
            }

            Label3.Text = "Antiban OFF, Don't Play";
            Label3.ForeColor = Color.Red;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            GL();

            Label3.Text = "Antiban On,Enjoy";
            Label3.ForeColor = Color.Lime;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Label1.Text = "Expire IN: " + UserInfo.Expires.ToString("yyyy-MM-dd hh:mm:ss tt");
            ComboBox1.Enabled = false;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                newpoint = MousePosition;
                newpoint.X -= x22;
                newpoint.Y -= y;
                Location = newpoint;
                Application.DoEvents();
            }
        }
    }
}