// Decompiled with JetBrains decompiler
// Type: Записная_книжка.Program
// Assembly: Записная книжка, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A0D518A3-D4BA-4371-9C44-D7D6E9D22E50
// Assembly location: D:\Драгоценный исходник записной книжки\Записная книжка.exe

using System;
using System.Windows.Forms;

namespace Записная_книжка
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new MainWindow());
    }
  }
}
