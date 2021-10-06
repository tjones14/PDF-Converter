using Spire.Pdf;
using Spire.Pdf.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF_Converter.Utilities
{
    public static class Converters
    {

        // public static interface GetConverter(string filename)
        // Need to create an interface that will automatically call the method for the correct converter based
        // on file type. 



        public static PdfDocument ImageConverter(string fileName)
        {

            PdfDocument doc = new PdfDocument();
            PdfSection section = doc.Sections.Add();
            PdfPageBase page = doc.Pages.Add();

            PdfImage image = PdfImage.FromFile(fileName);

            float widthFitRate = image.PhysicalDimension.Width / page.Canvas.ClientSize.Width;
            float heightFitRate = image.PhysicalDimension.Height / page.Canvas.ClientSize.Height;
            float fitRate = Math.Max(widthFitRate, heightFitRate);
            float fitWidth = image.PhysicalDimension.Width / fitRate;
            float fitHeight = image.PhysicalDimension.Height / fitRate;
            page.Canvas.DrawImage(image, 30, 30, fitWidth, fitHeight);

            return doc;

        }

        public static PdfDocument WordConverter(string fileName)
        {
            PdfDocument doc = new PdfDocument();

            var splitfile = fileName.Split('.');
            var extension = splitfile[1].ToUpper();

            doc.LoadFromFile(fileName);


            return doc;
        }

    }
}
