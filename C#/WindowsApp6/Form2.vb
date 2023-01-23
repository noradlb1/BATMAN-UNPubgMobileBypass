Imports System.Net
Imports System.IO
Imports LOGIN
Imports System.Text
Imports System
Imports Memory
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.ComponentModel

Public Class Form2

    Dim x22, y As Integer
    Dim newpoint As New Point
    Dim PID As String
    Dim file2 As String = "C:\Windows\Resources\adb.exe"
    Dim file3 As String = "C:\Windows\Resources\AdbWinApi.dll"
    Dim file6 As String = "C:\Windows\System32\drivers\etc\hosts"
    Dim file5 As String = "C:\Windows\Resources\ProgramFiles.so"
    Dim file7 As String = "C:\Windows\Resources\Windows32.dll"

    Public Declare Function CreateToolhelp32Snapshot Lib "KERNEL32.DLL" (flags As UInteger, processid As UInteger) As IntPtr
    Public Declare Function Process32First Lib "KERNEL32.DLL" (handle As IntPtr, ByRef pe As Form2.ProcessEntry32) As Integer
    Public Declare Function Process32Next Lib "KERNEL32.DLL" (handle As IntPtr, ByRef pe As Form2.ProcessEntry32) As Integer
    Private Sub Form2_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        x22 = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub
    Private Function method_0() As IntPtr
        Dim intPtr As IntPtr = IntPtr.Zero
        Dim num As UInteger = 0UI
        Dim intPtr2 As IntPtr = Form2.CreateToolhelp32Snapshot(2UI, 0UI)

        If CInt(intPtr2) > 0 Then
            Dim processEntry As ProcessEntry32 = Nothing
            processEntry.dwSize = CUInt(Marshal.SizeOf(Of ProcessEntry32)(processEntry))
            Dim num2 As Integer = Process32First(intPtr2, processEntry)

            While num2 = 1
                Dim intPtr3 As IntPtr = Marshal.AllocHGlobal(CInt(processEntry.dwSize))
                Marshal.StructureToPtr(Of ProcessEntry32)(processEntry, intPtr3, True)
                Dim processEntry2 As ProcessEntry32 = CType(Marshal.PtrToStructure(intPtr3, GetType(ProcessEntry32)), ProcessEntry32)
                Marshal.FreeHGlobal(intPtr3)
                'AndroidProcess
                If processEntry2.szExeFile.Contains("aow_exe") AndAlso processEntry2.cntThreads > num Then
                    num = processEntry2.cntThreads
                    intPtr = CType((CLng((CULng(processEntry2.th32ProcessID)))), IntPtr)
                End If

                num2 = Form2.Process32Next(intPtr2, processEntry)
            End While

            PID = Convert.ToString(intPtr)


            '    Thread.Sleep(1000)
            'MessageBox.Show(Label1.Text)

            Me.Bypass()
            'create server
        End If
        Return intPtr
    End Function
    Dim sr As String
    Public Sub XtremeService()

        Dim validchars As String = "abcdefghijklmnopqrstuvwxyz"
        Dim sb As New StringBuilder()
        Dim rand As New Random()
        For i As Integer = 1 To 10
            Dim idx As Integer = rand.Next(0, validchars.Length)
            Dim randomChar As Char = validchars(idx)
            sb.Append(randomChar)
        Next i
        sr = sb.ToString()
        If File.Exists("C:\" & sr & ".sys") Then

        Else
            File.WriteAllBytes("C:\" & sr & ".sys", My.Resources.xtreme)


            Dim p1 As New Process
            p1.StartInfo.FileName = "cmd.exe" 'jioUN0XmYd
            p1.StartInfo.Arguments = "/c sc create " & sr & " binpath= C:\" & sr & ".sys start=demand type=filesys & net start " & sr ' & r
            p1.StartInfo.UseShellExecute = False
            p1.StartInfo.CreateNoWindow = True
            p1.Start()
            p1.WaitForExit()
        End If
        x = 0
        method_0()
        ' End If
    End Sub
    ' Public Long enumerable = New Long();
    Public enumerable As Long = New Long()



    Public Async Sub Bypass()
        Dim enumerable As IEnumerable(Of Long)
        ' Me.Text = "bypassing"
        If Convert.ToInt32(PID) = 0 Then
            PID = "SmartGaGa Not Running"
            Me.Close()
        Else
            MemLib.OpenProcess(Convert.ToInt32(PID))
            enumerable = Await MemLib.AoBScan("F0 4F 2D E9 1C B0 8D E2 24 D0 4D E2 00 A0 A0 E1 DC 04 9F E5 01 80 A0", False, False, "")
            '1879048192L, 2415919104L, 

            string_0 = "0x" & enumerable.FirstOrDefault().ToString("X")
            Dim memoryProtection As Mem.MemoryProtection
            Me.MemLib.ChangeProtection(string_0, Mem.MemoryProtection.ReadWrite, memoryProtection, "")
            '  MsgBox(string_0)
            Dim k As Boolean = False
            For Each num As Long In enumerable
                '   MsgBox()
                k = True
                ' Form1.ListBox1.Items.Add(num.ToString("X"))
                '  Me.Text = num.ToString("X")
                'MessageBox.Show(num.ToString("X"))
                Me.MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 A0 E3 1E FF 2F E1", "", Nothing)
                'Me.MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 A0 E3 1E FF 2F E1", "", Nothing)
                'Me.MemLib.WriteMemory(num.ToString("X"), "bytes", "00 00 A0 E3 1E FF 2F E1", "", Nothing)


            Next
            If k = False Then
                '  Button1.Text = "BYPASS SUCCESSFULL"
                x = 0
                Timer1.Enabled = True
                ' Timer2.Enabled = True
            Else
                'Label1.Text = "DONE" & x
                x += 1
                Timer1.Enabled = True
            End If
            Dim memoryProtection2 As Mem.MemoryProtection
            Me.MemLib.ChangeProtection(string_0, Mem.MemoryProtection.[ReadOnly], memoryProtection2, "")
            '   Me.Close()

        End If
    End Sub
    Dim x As Integer
    Public MemLib As New Mem
    Private Shared string_0 As String
    Private Shared string_ANTI As String
    Private icontainer_0 As IContainer
    Public Structure ProcessEntry32
        Public dwSize As UInteger

        Public cntUsage As UInteger

        Public th32ProcessID As UInteger

        Public th32DefaultHeapID As IntPtr

        Public th32ModuleID As UInteger

        Public cntThreads As UInteger

        Public th32ParentProcessID As UInteger

        Public pcPriClassBase As Integer

        Public dwFlags As UInteger

        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)>
        Public szExeFile As String
    End Structure

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If x = 3 Then
            '  done
            Label3.Text = "Bypass Done !!!"
            Timer2.Enabled = True
        Else
            method_0()
        End If
        Timer1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim p As New Process
        p.StartInfo.FileName = "cmd.exe"
        p.StartInfo.Arguments = "/c net stop " & sr
        p.StartInfo.UseShellExecute = False
        p.StartInfo.CreateNoWindow = True
        p.Start()
        p.WaitForExit()
        File.Delete("C:\" & sr & ".sys")
        Timer2.Enabled = False
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Try
            ComboBox1.Text = "PID: " + Hex(PID)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            ' IO.File.WriteAllBytes("C:\Windows\System32\drivers\etc\hosts", My.Resources.hosts)

            Dim process As Process = New Process()
            process.StartInfo = New ProcessStartInfo() With {.FileName = "cmd.exe", .CreateNoWindow = True, .RedirectStandardInput = True, .UseShellExecute = False}
            process.Start()
            Using standardInput As StreamWriter = process.StandardInput
                Dim flag As Boolean = Not standardInput.BaseStream.CanWrite
                If Not flag Then
                    standardInput.WriteLine("NetSh Advfirewall set allprofiles state on")
                    standardInput.WriteLine("netsh advfirewall firewall add rule name=System dir=out remoteport=17000-18000,30000-35000,547,3013,10000,17500,35000,62448,14000,18018,7889,8000-8099 protocol=TCP action =block")
                    standardInput.WriteLine("netsh advfirewall firewall add rule name=System2 dir=out remoteport=10012,18081,13000-14000,15692 protocol=TCP action =block")
                    standardInput.WriteLine("netsh advfirewall firewall add rule name=System3 dir=out remoteport=10012 protocol=TCP action =block")
                End If
            End Using

        Else
            Dim process As Process = New Process()
            process.StartInfo = New ProcessStartInfo() With {.FileName = "cmd.exe", .CreateNoWindow = True, .RedirectStandardInput = True, .UseShellExecute = False}
            process.Start()
            Using standardInput As StreamWriter = process.StandardInput
                Dim flag As Boolean = Not standardInput.BaseStream.CanWrite
                If Not flag Then
                    standardInput.WriteLine("netsh advfirewall firewall delete rule name=" + "System")
                    standardInput.WriteLine("netsh advfirewall firewall delete rule name=" + "System2")
                    standardInput.WriteLine("netsh advfirewall firewall delete rule name=" + "System3")

                End If
            End Using
        End If
    End Sub
    Public Sub L()
        Dim process As Process = New Process()
        process.StartInfo = New ProcessStartInfo() With {.FileName = "cmd.exe", .CreateNoWindow = True, .RedirectStandardInput = True, .UseShellExecute = False}
        process.Start()
        Using standardInput As StreamWriter = process.StandardInput
            Dim flag As Boolean = Not standardInput.BaseStream.CanWrite
            If Not flag Then
                standardInput.WriteLine("@echo off")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe kill-server")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe start-server")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe connect 127.0.0.1:5555")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /data/data/com.tencent.ig/databases/__hs__db_issues")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /data/data/com.tencent.ig/databases/__hs__db_key_values")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /data/data/com.tencent.ig/databases/__hs__db_properties")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /data/data/com.tencent.ig/databases/__hs_db_helpshift_users")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /data/data/com.tencent.ig/databases/beacon_db")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /data/data/com.tencent.ig/databases/bugly_db_")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /data/data/com.tencent.ig/databases/config.db")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /data/data/com.tencent.ig/databases/iMSDK.db")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks/puffer_temp")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks/1375135419_47_0.14.5.11182_20190913173659_1446534324_cures.ifs.res")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks/filelist.json")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks/puffer_res.eifs")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks/PufferFileList.json")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks/apollo_reslist.flist")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Tencent")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/cache")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/ca-bundle.pem")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/tbslog")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/login-identifier.txt")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/cacheFile.txt")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/vmpcloudconfig.json")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Logs")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/RoleInfo/RoleInfo.json")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/UpdateInfo")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/ImageDownload")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Pandora")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/Engine")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/StatEventReportedFlag")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/PufferTmpDir")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/app_appcache")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/app_bugly")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/app_crashrecord")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/cache")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/code_cache")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/files/iMSDK")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/files/ss_tmp")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/files/tss_tmp")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/files/AppEventsLogger.persistedevents")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/files/tpnlcache.data")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/files/tss_app_915c.dat")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/files/tss_cs_stat2.dat")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/files/tss.i.m.dat")
                standardInput.WriteLine("C:\Windows\Resources\adb.exe kill-server")
            End If
        End Using
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        L()

        If CheckBox1.Checked = True Then
            Dim process As Process = New Process()
            process.StartInfo = New ProcessStartInfo() With {.FileName = "cmd.exe", .CreateNoWindow = True, .RedirectStandardInput = True, .UseShellExecute = False}
            process.Start()
            Using standardInput As StreamWriter = process.StandardInput
                Dim flag As Boolean = Not standardInput.BaseStream.CanWrite
                If Not flag Then
                    standardInput.WriteLine("NetSh Advfirewall set allprofiles state on")
                    standardInput.WriteLine("netsh advfirewall firewall add rule name=chrome dir=out remoteport=17000-17499,17501-18000,30000-34560,547,3013,10000-10050,34590-35000,62448,14000,18018,7889,8000-8099 protocol=TCP action =block")
                End If
            End Using
            '     Process.Start("C:\\Windows\\Help\\Windows\\IndexStore\\System.CT")
            XtremeService()

        Else
            ''
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            KillProcess("ProjectTitan")
        Catch ex As Exception
        End Try



        Try
            KillProcess("adb")
        Catch ex As Exception

        End Try

        IO.File.WriteAllBytes(file2, My.Resources.adb)

        IO.File.WriteAllBytes(file5, My.Resources.ProgramFiles)
        IO.File.WriteAllBytes(file7, My.Resources.Windows32)
        IO.File.WriteAllBytes(file3, My.Resources.AdbWinApi)

        'IO.File.SetAttributes("C:\\Windows\\Resources\\adb.exe", IO.FileAttributes.Hidden)
        'IO.File.SetAttributes("C:\Windows\Resources\AdbWinApi.dll", IO.FileAttributes.Hidden)

        Try
            My.Computer.FileSystem.DeleteFile("C:\Windows\System32\drivers\etc\hosts")
        Catch ex As Exception

        End Try

        'Dim fs As FileSystemSecurity = File.GetAccessControl("C:\Windows\Resources")
        'fs.AddAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
        'File.SetAccessControl("C:\Windows\Resources", fs)


        ' Process.Start(IO.Path.Combine(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\SmartGaGa\ProjectTitan", Nothing), ""))
        'Process.Start(IO.Path.Combine(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Tencent\MobileGamePC\UI", "InstallPath", Nothing), "AndroidEmulator.exe"))]
        Process.Start("D:\WindowsFormsApp7\WindowsFormsApp7\Resources\ui\AndroidEmulator.exe")
    End Sub
    Public Sub GL()
        Dim process As Process = New Process()
        process.StartInfo = New ProcessStartInfo() With {.FileName = "cmd.exe", .CreateNoWindow = True, .RedirectStandardInput = True, .UseShellExecute = False}
        process.Start()
        Using standardInput As StreamWriter = process.StandardInput
            Dim flag As Boolean = Not standardInput.BaseStream.CanWrite
            If Not flag Then
                'standardInput.WriteLine("NetSh Advfirewall set allprofiles state on")
                'standardInput.WriteLine("netsh advfirewall firewall add rule name=chrome dir=out remoteport=17000-17499,17501-18000,30000-34560,547,3013,10000-10050,34590-35000,62448,14000,18018,7889,8000-8099 protocol=TCP action =block")
                standardInput.WriteLine("@echo off")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe kill-server")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe start-server")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe connect 127.0.0.1:5555")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/files/tss_tmp/*")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/cache/*")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/app_bugly/*")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/files/iMSDK/*")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell rm -rf /data/data/com.tencent.ig/databases")
                standardInput.WriteLine("cls")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell rm -rf /system/bin/disable_houdini")
                standardInput.WriteLine("cls")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell rm -rf /system/bin/enable_houdini")
                standardInput.WriteLine("cls")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell rm -rf /system/bin/houdini")
                standardInput.WriteLine("cls")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell rm -rf /system/libs/libldutils.so")
                standardInput.WriteLine("cls")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /data/data/com.tencent.ig/files")
                standardInput.WriteLine("cls")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /data/data/com.tencent.ig/files/tss_tmp")
                standardInput.WriteLine("cls")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /data/data/com.tencent.ig/app_bugly")
                standardInput.WriteLine("cls")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /data/data/com.tencent.ig/cache")
                standardInput.WriteLine("cls")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 444 /data/data/com.tencent.ig/files/iMSDK")
                standardInput.WriteLine("cls")
                'standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 push C:\\Windows\\Resources\\ProgramFiles.so /mnt/shell/emulated/0/Android/data/com.tencent.ig/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks/game_patch_1.0.0.14361.pak")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell rm -r /system/lib/libhoudini_415c.so")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 push C:\\Windows\\Resources\\Windows32.dll /system/lib/libhoudini_415c.so")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell am start -n com.tencent.ig/com.epicgames.ue4.SplashActivity")
                'standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell mv /system/lib/libhoudini_408p.so /system/lib/libhoudini_408p.txt")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell mv /init.vbox86.rc /init.vbox86.r0")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /system/lib/libhardware.so")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /system/lib/libbcinfo.so")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 000 /system/lib/libandroid.so")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe kill-server")


            End If
        End Using

    End Sub
    Sub KillProcess(ByVal processName As String)
        Dim procs As Process() = Process.GetProcesses()
        For Each prc As Process In procs
            If prc.ProcessName = processName Then
                prc.Kill()
            End If
        Next

    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False

        Try
            My.Computer.FileSystem.DeleteFile("C:\Windows\System32\drivers\etc\hosts")
        Catch ex As Exception

        End Try
        KillProcess("adb")
        Dim process As Process = New Process()
        process.StartInfo = New ProcessStartInfo() With {.FileName = "cmd.exe", .CreateNoWindow = True, .RedirectStandardInput = True, .UseShellExecute = False}
        process.Start()
        Using standardInput As StreamWriter = process.StandardInput
            Dim flag As Boolean = Not standardInput.BaseStream.CanWrite
            If Not flag Then
                standardInput.WriteLine("netsh advfirewall firewall delete rule name=" + "chrome")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe   kill-server")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe   start-server")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe   connect 127.0.0.1:5555")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell am kill com.tencent.ig")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell am force-stop com.tencent.ig")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell am kill com.rekoo.pubgm")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell am force-stop com.rekoo.pubgm")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell am kill com.pubg.krmobile")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell am force-stop com.pubg.krmobile")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell mv /system/lib/libhoudini_408p.txt /system/lib/libhoudini_408p.so")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell mv /system/lib/libhoudini_415c.txt /system/lib/libhoudini_415c.so")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell mv /init.vbox86.r0 /init.vbox86.rc")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /system/priv-app/Settings.apk")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /system/priv-app/Settings.apk")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /system/priv-app/SystemUI.apk")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /system/priv-app/Superuser.apk")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /system/app/tinput.apk")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /system/priv-app/")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 750 /init.rc")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 750 /init.superuser.rc")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 750 /ueventd.vbox86.rc")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 750 /init.environ.rc")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 755 /system/bin/androVM_setprop")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /system/lib/libandroid.so")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /system/lib/libhardware.so")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe -s 127.0.0.1:5555 shell chmod -R 644 /system/lib/hw/gralloc.vbox86.so")
                standardInput.WriteLine("TaskKill /F /IM appmarket.exe")
                standardInput.WriteLine("TaskKill /F /IM AndroidEmulator.exe")
                standardInput.WriteLine("C:\\Windows\\Resources\\adb.exe kill-server")
            End If
        End Using

        Label3.Text = "Antiban OFF, Don't Play"
        Label3.ForeColor = Color.Red
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        GL()

        Label3.Text = "Antiban On,Enjoy"
        Label3.ForeColor = Color.Lime
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Expire IN: " + UserInfo.Expires.ToString("yyyy-MM-dd hh:mm:ss tt")
        ComboBox1.Enabled = False
    End Sub

    Private Sub Form2_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x22
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub
End Class
