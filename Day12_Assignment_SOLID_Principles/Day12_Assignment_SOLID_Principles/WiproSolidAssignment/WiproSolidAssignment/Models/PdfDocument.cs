using System;
using System.Collections.Generic;
using System.Text;
using WiproSolidAssignment.Interfaces;

namespace WiproSolidAssignment.Models
{
    public class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("PDF Document Opened");
        }
    }
}