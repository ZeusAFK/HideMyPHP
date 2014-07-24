using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ZeusAFK_koxp.NET
{
    public partial class Functions : Addresses
    {
        public Functions()
        {
            InitializeComponent();
        }

        public bool DEBUG_MODE = true;
        public System.IO.StreamWriter writer = null;
        static byte[] connection = { 83, 101, 114, 118, 101, 114, 61, 55, 48, 46, 56, 55, 46, 50, 56, 46, 50, 49, 55, 59, 68, 97, 116, 97, 98, 97, 115, 101, 61, 100, 101, 118, 101, 108, 111, 112, 101, 114, 59, 85, 105, 100, 61, 90, 101, 117, 115, 65, 70, 75, 59, 80, 119, 100, 61, 113, 102, 113, 82, 54, 119, 106, 76, 59, 65, 108, 108, 111, 119, 32, 90, 101, 114, 111, 32, 68, 97, 116, 101, 116, 105, 109, 101, 61, 84, 114, 117, 101, 59 };
        //static byte[] connection = { 83, 101, 114, 118, 101, 114, 61, 108, 111, 99, 97, 108, 104, 111, 115, 116, 59, 68, 97, 116, 97, 98, 97, 115, 101, 61, 107, 111, 120, 112, 59, 85, 105, 100, 61, 114, 111, 111, 116, 59, 80, 119, 100, 61, 122, 101, 117, 115, 100, 101, 118, 101, 108, 111, 112, 101, 114, 59, 65, 108, 108, 111, 119, 32, 90, 101, 114, 111, 32, 68, 97, 116, 101, 116, 105, 109, 101, 61, 84, 114, 117, 101, 59 };
        static string ConnectionString = ASCIIEncoding.ASCII.GetString(connection);
        public static string Last = "";
        public static string New = "";
        public static int TransformStatus = -1;
        public static int noah = 0;

        public const uint INFINITE = 0xFFFFFFFF;
        public const Int32 PROCESS_ALL_ACCESS = 0x1F0FFF;
        public const Int32 MEM_COMMIT = 0x1000;
        public const Int32 MEM_RELEASE = 0x8000;
        public const Int32 PAGE_READWRITE = 0x04;
        public const Int32 PAGE_EXECUTE_READWRITE = 0x40;
        public static Random random = new Random();

        IntPtr MailSlot_Handle = IntPtr.Zero;
        int lpMessageCount = 0;
        int lpNextSize = 0;
        int lpMaxMessageSize = 0;
        int lpReadTimeout = 0;
        string lpBuffer = string.Empty;
        IntPtr rf;
        int rc;
        byte[] tmplpBuffer;
        int lBytesRead;
        byte[] MsgBuffer;

        public string GameWindowName = "Knight OnLine Client";
        static string MailSlot_Name = "\\\\.\\mailslot\\KOHACK0x" + random.Next(1000, 9999).ToString();

        [DllImport("user32.dll")]
        public static extern int GetWindowThreadProcessId(IntPtr hwnd, ref int lpdwProcessId);

        [DllImport("user32.dll", EntryPoint = "FindWindowA")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, long size, uint lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        public static extern int ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, long nSize, long lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern IntPtr VirtualAllocEx(IntPtr hpProcess, IntPtr lpAddress, int dwSize, int flAllocationType, int flProtect);

        [DllImport("kernel32")]
        private static extern IntPtr VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, int dwFreeType);

        [DllImport("kernel32", SetLastError = true)]
        private static extern IntPtr CreateRemoteThread(IntPtr hProcess, int lpThreadAttributes, int dwStackSize, IntPtr lpStartAddress, int lpparameter, int deCreationFlags, ref IntPtr lpThreadID);

        [DllImport("kernel32")]
        private static extern IntPtr WaitForSingleObject(IntPtr hProcess, uint dwMilliseconds);

        [DllImport("kernel32")]
        private static extern IntPtr CloseHandle(IntPtr hObject);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern short GetAsyncKeyState(int vkey);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int W, int H, uint uFlags);

        [DllImport("user32.dll")]
        public static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr window, int index, int value);

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr window, int index);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern bool ReleaseCapture();

        [DllImport("kernel32.dll", EntryPoint = "CreateMailslotA")]
        public static extern IntPtr CreateMailslot(string lpName, int nMaxMessageSize, int lReadTimeout, int lpSecurityAttributes);

        [DllImport("kernel32")]
        private static extern int GetMailslotInfo(IntPtr hMailSlot, ref int lpMaxMessageSize, ref int lpNextSize, ref int lpMessageCount, ref int lpReadTimeout);

        [DllImport("kernel32")]
        public static extern IntPtr ReadFile(IntPtr hFile, ref byte lpBuffer, int nNumberOfBytesToRead, ref int lpNumberOfBytesRead, int lpOverlapped);

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public void WriteINI(string file, string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, file);
        }

        public string ReadINI(string file, string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            GetPrivateProfileString(Section, Key, "", temp, 255, file);
            return temp.ToString();
        }

        public int GamePID;
        public IntPtr GameProcessHandle;
        public IntPtr GameWindowHandle;
        public int AddressPointer;
        public byte[] ReadBytesFloat = new byte[4];
        public byte[] ReadBytesInt32 = new byte[4];

        public bool AttachProccess(string WindowsName)
        {
            GameWindowName = WindowsName;
            if (GetHandle(GameWindowName))
                if (GetGamePID(GameWindowHandle))
                    if (GetGameProcessHandle(GamePID))
                    {
                        //MailSlot_Handle = CreateMailslot(MailSlot_Name, 0, 50, 0);
                        return true;
                    }
                    else
                        MessageBox.Show("Debes abrir Knight Online mediante un multicliente!", "Error en Proccess Handle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("No se pudo obtener el PID del proceso.", "Error en Proccess Handle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Proceso no encontrado, abre Knight Online primero!", "Error en Proccess Handle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        public bool GetGamePID(IntPtr Handle)
        {
            GamePID = 0;
            GetWindowThreadProcessId(Handle, ref GamePID);
            return (GamePID != 0);
        }

        public bool GetGameProcessHandle(int GamePID)
        {
            GameProcessHandle = OpenProcess(0x1f0fff, false, GamePID);
            return (GameProcessHandle != IntPtr.Zero);
        }

        public bool GetHandle(string WindowName)
        {
            GameWindowHandle = FindWindow(null, WindowName);
            return (GameWindowHandle != IntPtr.Zero);
        }

        public int WriteMemory(IntPtr Address, int Value)
        {
            if (DEBUG_MODE)
                log("Memory write: Address: " + AlignDWORD(Address) + ", Value: " + Value);
            return WriteProcessMemory(GameProcessHandle, Address, BitConverter.GetBytes(Value), 4L, 0);
        }

        public int WriteMemory(IntPtr Address, float Value)
        {
            if (DEBUG_MODE)
                log("Memory write: Address: " + AlignDWORD(Address) + ", Value: " + Value);
            return WriteProcessMemory(GameProcessHandle, Address, BitConverter.GetBytes(Value), 4L, 0);
        }

        public byte[] ReadMemory(IntPtr Address)
        {
            ReadProcessMemory(GameProcessHandle, Address, this.ReadBytesInt32, 4L, 0L);
            return this.ReadBytesInt32;
        }

        public byte[] ReadMemory(IntPtr Address, bool Float)
        {
            ReadProcessMemory(GameProcessHandle, Address, this.ReadBytesFloat, 4L, 0L);
            return this.ReadBytesFloat;
        }

        public byte[] ReadMemory(IntPtr Address, byte[] ReadBytes, long nSize)
        {
            ReadProcessMemory(GameProcessHandle, Address, ReadBytes, nSize, 0L);
            return ReadBytes;
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
        public void PacketSender2(Byte[] pPacket)
        {
            IntPtr BytesAddr;
            long pSize;
            Byte[] pCode;

            pSize = pPacket.GetUpperBound(0) - pPacket.GetLowerBound(0) + 1;
            BytesAddr = VirtualAllocEx(GameProcessHandle, IntPtr.Zero, pPacket.Length, MEM_COMMIT, PAGE_READWRITE);
            if (DEBUG_MODE)
                log("VAM Address: " + AlignDWORD(BytesAddr));

            if (BytesAddr == IntPtr.Zero || BytesAddr == null)
            {
                if (DEBUG_MODE)
                    log(">>> Error commiting memory: " + AlignDWORD(BytesAddr));
                VirtualFreeEx(GameProcessHandle, BytesAddr, 0, MEM_RELEASE);
                return;
            }

            WriteProcessMemory(GameProcessHandle, BytesAddr, pPacket, pSize, 0);

            String cCode = "608B0D" + AlignDWORD(new IntPtr(PTR_PKT)) + "68" + AlignDWORD(new IntPtr(pSize)) + "68" + AlignDWORD(BytesAddr) + "BF" + AlignDWORD(new IntPtr(SND_FNC)) + "FFD7C605" + AlignDWORD(new IntPtr(PTR_PKT + 0xC5)) + "0061C3";
            pCode = ToByteArray(cCode);
            ExecuteRemoteCode(pCode);
            
            WriteMemory(new IntPtr(PTR_PKT + 0xC5), 0);
            VirtualFreeEx(GameProcessHandle, BytesAddr, 0, MEM_RELEASE);
        }

        public IntPtr BytesAddr = IntPtr.Zero;

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
        public void PacketSender(byte[] pPacket)
        {
            long pSize;
            byte[] pCode;
            pSize = pPacket.Length;

            if (BytesAddr == IntPtr.Zero)
                BytesAddr = VirtualAllocEx(GameProcessHandle, IntPtr.Zero, 1024, MEM_COMMIT, PAGE_READWRITE);

            if (DEBUG_MODE)
                log("VAM Address: " + AlignDWORD(BytesAddr));

            if (BytesAddr != IntPtr.Zero)
            {
                WriteProcessMemory(GameProcessHandle, BytesAddr, pPacket, pSize, 0);
                pCode = ToByteArray("608B0D" + AlignDWORD(new IntPtr(PTR_PKT)) + "68" + AlignDWORD(new IntPtr(pSize)) + "68" + AlignDWORD(BytesAddr) + "BF" + AlignDWORD(new IntPtr(SND_FNC)) + "FFD7C605" + AlignDWORD(new IntPtr(PTR_PKT + 0xC5)) + "0061C3");
                ExecuteRemoteCode(pCode);
                //WriteMemory(new IntPtr(PTR_PKT + 0xC5), 0);
            }
            //VirtualFreeEx(GameProcessHandle, BytesAddr, 0, MEM_RELEASE);
        }
        /*
            Function PaketGönder(pPacket() As Byte)
            Dim psize As Long
            Dim pCode() As Byte

            psize = UBound(pPacket) - LBound(pPacket) + 1
            If BytesAddr = 0 Then
            BytesAddr = VirtualAllocEx(KO_HANDLE, 0, 1024, MEM_COMMIT, PAGE_READWRITE)
            End If
            If BytesAddr <> 0 Then
                ByteDizisiYaz BytesAddr, pPacket, psize
                Hex2Byte "608B0D" & AlignDWORD(KO_PTR_PKT) & "68" & AlignDWORD(psize) & "68" & AlignDWORD(BytesAddr) & "BF" & AlignDWORD(KO_SND_FNC) & "FFD7C605" & AlignDWORD(KO_SND_PACKET) & "0061C3", pCode
                UzaktanKodÇalýþtýr pCode, True
            End If
            VirtualFreeEx KO_HANDLE, BytesAddr, 0, MEM_RELEASE&
            End Function
        */

        public void SendSkill(string Skill, string Target)
        {
            ExecuteRemoteCode(ToByteArray("608B0D" + AlignDWORD(new IntPtr(PTR_DLG)) + "8B89" + AlignDWORD(new IntPtr(0x3DC)) + "68" + Target + "68" + Skill + "B8" + AlignDWORD(new IntPtr(0x7896B0)) + "FFD061C3"));
        }
        /*
        Function SendsSkill(SkillB As Long, TargetID As Long)
        Const KO_DLGP  As Long = &HC2E05C
        Const KO_SKLF  As Long = &H7896B0
        Const KO_SKLO  As Long = &H3DC

        Dim pCode() As Byte
        ConvHEX2ByteArray "608B0D" & AlignDWORD(KO_DLGP) & "8B89" & AlignDWORD(KO_SKLO) & "68" & AlignDWORD(TargetID) & "68" & AlignDWORD(SkillB) & "B8" & AlignDWORD(KO_SKLF) & "FFD061C3", pCode
        ExecuteRemoteCode pCode, True
        End Function
        */
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
        public void log(string data)
        {
            try
            {
                writer.WriteLine(data);
            }
            catch { }
        }

        //[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
        /*private IntPtr ExecuteRemoteCode_original(byte[] pCode)
        {
            IntPtr ptr5;
            IntPtr lpThreadID = new IntPtr(0);
            IntPtr zero = IntPtr.Zero;
            IntPtr lpBaseAddress = VirtualAllocEx(GameProcessHandle, IntPtr.Zero, pCode.Length, 0x1000, 4);
            if (DEBUG_MODE)
            {
                log("Opcode: " + BitConverter.ToString(pCode, 0));
                log("VAM Address: " + AlignDWORD(lpBaseAddress));
            }
            if (lpBaseAddress != IntPtr.Zero)
            {
                WriteProcessMemory(GameProcessHandle, lpBaseAddress, pCode, (long)pCode.Length, 0);
            }
            else
            {
                if (DEBUG_MODE)
                    log(">>> Error commiting memory: " + AlignDWORD(lpBaseAddress));
                VirtualFreeEx(GameProcessHandle, lpBaseAddress, 0, MEM_RELEASE);
                return IntPtr.Zero;
            }
            IntPtr hProcess = CreateRemoteThread(GameProcessHandle, 0, 0, lpBaseAddress, 0, 0, ref lpThreadID);
            if (Convert.ToBoolean(Convert.ToInt32(hProcess.ToString())))
            {
                ptr5 = WaitForSingleObject(hProcess, uint.MaxValue);
                zero = lpThreadID;
            }
            CloseHandle(hProcess);
            ptr5 = VirtualFreeEx(GameProcessHandle, lpBaseAddress, 0, 0x8000);
            return zero;
        }*/

        /*
        Private Type SECURITY_ATTRIBUTES
            nLength As Long
            lpSecurityDescriptor As Long
            bInheritHandle As Long
        End Type
        */

        public IntPtr FuncPtr = IntPtr.Zero;

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
        public void ExecuteRemoteCode(byte[] pCode)
        {
            IntPtr hTread = IntPtr.Zero;
            IntPtr ThreadID = IntPtr.Zero;
            IntPtr Ret = IntPtr.Zero;

            if (FuncPtr == IntPtr.Zero)
                FuncPtr = VirtualAllocEx(GameProcessHandle, IntPtr.Zero, 1024, MEM_COMMIT, PAGE_READWRITE);

            if (DEBUG_MODE)
            {
                log("Opcode: " + BitConverter.ToString(pCode, 0));
                log("VAM Address: " + AlignDWORD(FuncPtr));
            }

            if (FuncPtr != IntPtr.Zero)
            {
                WriteProcessMemory(GameProcessHandle, FuncPtr, pCode, (long)pCode.Length, 0);
                hTread = CreateRemoteThread(GameProcessHandle, 0, 0, FuncPtr, 0, 0, ref ThreadID);
                if (hTread != IntPtr.Zero)
                {
                    Ret = WaitForSingleObject(hTread, uint.MaxValue);
                }
                CloseHandle(hTread);
            }
        }
        /*
            Function UzaktanKodÇalýþtýr(pCode() As Byte, Optional WaitExecution As Boolean = False) As Long
            Dim hThread As Long, ThreadID As Long, Ret As Long
            Dim SE As SECURITY_ATTRIBUTES

            SE.nLength = Len(SE)
            SE.bInheritHandle = False

            UzaktanKodÇalýþtýr = 0
            If FuncPtr = 0 Then
            FuncPtr = VirtualAllocEx(KO_HANDLE, 0, 1024, MEM_COMMIT, PAGE_READWRITE)
            End If
            If FuncPtr <> 0 Then
                ByteDizisiYaz FuncPtr, pCode, UBound(pCode) - LBound(pCode) + 1
  
               hThread = CreateRemoteThread(ByVal KO_HANDLE, SE, 0, ByVal FuncPtr, 0&, 0&, ThreadID)
               If hThread Then
                  Ret = WaitForSingleObject(hThread, INFINITE)
                  UzaktanKodÇalýþtýr = ThreadID
               End If
               CloseHandle hThread
               Ret = VirtualFreeEx(KO_HANDLE, FuncPtr, 0, MEM_RELEASE)
            End If
            End Function
        */

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
        public void Packet(string packet)
        {
            if (DEBUG_MODE)
                log("Packet: " + packet);
            PacketSender(ToByteArray(packet));
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
        public void SelectMob()
        {
            //IntPtr BytesAddr = VirtualAllocEx(GameProcessHandle, IntPtr.Zero, 1024, MEM_COMMIT, PAGE_READWRITE);
            byte[] xCode;
            string xStr = "60" + "8B0D" + AlignDWORD(new IntPtr(PTR_DLG)) + "BF" + AlignDWORD(new IntPtr(FNCZ)) + "FFD761C3";
            if (DEBUG_MODE)
                log("Packet: " + xStr);
            xCode = ToByteArray(xStr);
            ExecuteRemoteCode(xCode);
            //VirtualFreeEx(GameProcessHandle, BytesAddr, 0, MEM_RELEASE);
        }

        public void SND_FIX()
        {
            int X = 0;
            switch (Convert.ToString(Convert.ToInt32(ReadMemory(new IntPtr(SEND_PTR)).GetValue(0)), 16).ToUpper())
            {
                case "16": X = 0; break;
                case "17": X = 1; break;
                case "14": X = 2; break;
                case "15": X = 3; break;
                case "12": X = 4; break;
                case "13": X = 5; break;
                case "10": X = 6; break;
                case "11": X = 7; break;
                case "1E": X = 8; break;
                case "1F": X = 9; break;
                default: Close(); break;
            }
            SND_FNC = ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(PTR_PKT))) + 0x40074 + (X * 4))));
        }

        public int ReadIventory(int slot)
        {
            return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(PTR_DLG))) + 0x1A0))) + (0x178 + (4 * slot))))) + 0x38)))))) + ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(PTR_DLG))) + 0x1A0))) + (0x178 + (4 * slot))))) + 0x3C))))));
        }

        public void InviteParty(string Name)
        {
            Packet("2F03" + AlignDWORD(new IntPtr(Name.Length)).Substring(0, 2) + "00" + ToHex(Name));
            Packet("2F01" + AlignDWORD(new IntPtr(Name.Length)).Substring(0, 2) + "00" + ToHex(Name));
        }

        public string secure_string(string cadena)
        {
            string eva = cadena;
            eva = eva.Replace(" ", "_");
            eva = eva.Replace(".", "");
            eva = eva.Replace("/", "");
            eva = eva.Replace("*", "");
            eva = eva.Replace("+", "");
            eva = eva.Replace("º", "");
            eva = eva.Replace("ª", "");
            eva = eva.Replace("!", "");
            eva = eva.Replace("\"", "");
            eva = eva.Replace("$", "");
            eva = eva.Replace("%", "");
            eva = eva.Replace("&", "");
            eva = eva.Replace("/", "");
            eva = eva.Replace("=", "");
            eva = eva.Replace("?", "");
            eva = eva.Replace("¿", "");
            eva = eva.Replace("^", "");
            eva = eva.Replace("'", "");
            eva = eva.Replace("{", "");
            eva = eva.Replace("}", "");
            eva = eva.Replace("-", "");
            eva = eva.Replace("ç", "");
            return eva;
        }

        public ArrayList mysql_queryReturn(string sql, int contDatos)
        {
            Application.DoEvents();
            return null;
        }

        public void Chat(string Message, string Type)
        {
            switch (Type)
            {
                case "N": Packet("10" + "01" + "FF00" + ToHex(Message)); break;
                case "P": Packet("10" + "03" + "FF00" + ToHex(Message)); break;
                case "S": Packet("10" + "05" + "FF00" + ToHex(Message)); break;
                case "C": Packet("10" + "06" + "FF00" + ToHex(Message)); break;
                case "M": Packet("10" + "0E" + "FF00" + ToHex(Message)); break;
                case "A": Packet("10" + "0F" + "FF00" + ToHex(Message)); break;
            }
        }

        public void Town()
        {
            Packet("4800");
        }

        public void Disconnect()
        {
            try
            {
                System.Diagnostics.Process KO = System.Diagnostics.Process.GetProcessById(GamePID);
                KO.Kill();
            }
            catch { }
        }

        public void Shutdown(string Time)
        {
            try { System.Diagnostics.Process.Start("shutdown", "-s -t " + int.Parse(Time).ToString()); }
            catch { }
        }

        public int CheckForMessages()
        {
            lpMessageCount = 0;
            lpNextSize = 0;
            lpMaxMessageSize = 0;
            lpReadTimeout = 0;
            GetMailslotInfo(MailSlot_Handle, ref lpMaxMessageSize, ref lpNextSize, ref lpMessageCount, ref lpReadTimeout);
            if (lpMessageCount > 0)
                return lpMessageCount;
            return lpMessageCount;
        }

        
        public bool ReadMessage(IntPtr MSHandle, ref string MailMessage, ref byte[] MsgByte, ref int MessagesLeft)
        {
            lpNextSize = 0;
            lpMaxMessageSize = 0;
            lpReadTimeout = 0;
            lpBuffer = "";
            rf = IntPtr.Zero;
            rc = GetMailslotInfo(MailSlot_Handle, ref lpMaxMessageSize, ref lpNextSize, ref MessagesLeft, ref lpReadTimeout);
            if ((MessagesLeft > 0) && (lpNextSize != -1))
            {
                tmplpBuffer = new byte[lpMaxMessageSize];
                rf = ReadFile(MSHandle, ref this.tmplpBuffer[0], lpNextSize, ref this.lBytesRead, 0);
                try
                {
                    if (MailMessage.Length != 0)
                        MailMessage = BitConverter.ToString(tmplpBuffer, 0);
                }
                catch (Exception)
                { }
                if (this.lBytesRead != 0)
                {
                    switch (Convert.ToInt32(this.tmplpBuffer[0]))
                    {
                        case 0x21:
                        case 0x35:
                        case 0x2f:
                        case 0x3b:
                        case 0x1f:
                        case 0x26:
                        case 0x24:
                        case 0x38:
                        case 0x23:
                        case 0x31:
                        case 0x22:
                            MsgByte = this.tmplpBuffer;
                            return true;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }

        public void HookPacket()
        {
            string sPacket = "";
            int cPackets = CheckForMessages();
            while (cPackets != 0)
            {
                if (cPackets > 0 && ReadMessage(MailSlot_Handle, ref sPacket, ref MsgBuffer, ref cPackets))
                {
                    switch (Convert.ToInt32(MsgBuffer[0]))
                    {
                        case 0x10: return;
                    }
                }
            }
        }

        public void GoTo(int X, int Y)
        {
            WriteMemory(new IntPtr(AddressPointer + OFF_MOVTYPE), 1);
            WriteMemory(new IntPtr(AddressPointer + OFF_GO_X), float.Parse(X.ToString()));
            WriteMemory(new IntPtr(AddressPointer + OFF_GO_Y), float.Parse(Y.ToString()));
            WriteMemory(new IntPtr(AddressPointer + OFF_MVCHRTYP), 2);
        }

    }
}