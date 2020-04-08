// Decompiled with JetBrains decompiler
// Type: Записная_книжка.Report
// Assembly: Записная книжка, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A0D518A3-D4BA-4371-9C44-D7D6E9D22E50
// Assembly location: D:\Драгоценный исходник записной книжки\Записная книжка.exe

using Elistia.DotNetRtfWriter;
using System.Collections.Generic;

namespace Записная_книжка
{
  internal class Report
  {
    private List<string> Records = new List<string>();
    private RtfDocument doc = new RtfDocument(PaperSize.A4, PaperOrientation.Portrait, Lcid.English);

    public Report(List<string> Records)
    {
      this.Records = Records;
      RtfParagraph rtfParagraph1 = this.doc.addParagraph();
      rtfParagraph1.Alignment = Align.Center;
      rtfParagraph1.DefaultCharFormat.Font = this.doc.createFont("Times New Roman");
      rtfParagraph1.DefaultCharFormat.FontSize = 16f;
      rtfParagraph1.setText("Отчёт за");
      RtfParagraph rtfParagraph2 = this.doc.addParagraph();
      rtfParagraph2.Alignment = Align.Left;
      rtfParagraph2.DefaultCharFormat.Font = this.doc.createFont("Calibri");
      rtfParagraph2.DefaultCharFormat.FontSize = 11f;
      rtfParagraph2.setText("Специалист:\nКайбазаков Андрей Сергеевич / __________\n");
      RtfTable rtfTable = this.doc.addTable(Records.Count, 1, 11f);
      for (int row = 0; row < Records.Count; ++row)
        rtfTable.cell(row, 0).addParagraph().setText("     " + Records[row]);
    }

    public void Save(string SavePath)
    {
      this.doc.save(SavePath);
    }
  }
}
