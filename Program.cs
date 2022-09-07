// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string keyValue = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
Microsoft.Win32.RegistryKey key;
// 这里你也可设置成 CurrentUser的。
key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(keyValue, true);
key.CreateSubKey("MyNewKey");
// 记得文件路径一定要加双引号。
key.SetValue("MyNewKey", "\"可执行文件的路径\"");
key.Close();