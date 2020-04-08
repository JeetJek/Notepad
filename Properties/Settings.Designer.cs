// Decompiled with JetBrains decompiler
// Type: Записная_книжка.Properties.Settings
// Assembly: Записная книжка, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A0D518A3-D4BA-4371-9C44-D7D6E9D22E50
// Assembly location: D:\Драгоценный исходник записной книжки\Записная книжка.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Записная_книжка.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings defaultInstance = Settings.defaultInstance;
        return defaultInstance;
      }
    }
  }
}
