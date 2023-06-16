using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinema_otomasyonu
{
    class cıktı
    {
            static void main()
            {
                PrintDocument PD = new PrintDocument();
                PD.PrintPage += new PrintPageEventHandler(OnPrintDocument);

                try
                {
                    PD.Print();
                }
                catch
                {
                    Console.WriteLine("Yazıcı çıktısı alınamıyor...");
                }
                finally
                {
                    PD.Dispose();
                }
            }

            private static void OnPrintDocument(object sender, PrintPageEventArgs e)
            {
                e.Graphics.DrawRectangle(Pens.Red, 20, 20, 100, 100);
            }
        }
}
