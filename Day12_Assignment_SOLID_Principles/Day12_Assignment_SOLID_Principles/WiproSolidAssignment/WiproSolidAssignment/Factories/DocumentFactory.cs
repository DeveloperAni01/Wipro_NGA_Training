using System;
using System.Collections.Generic;
using System.Text;
using WiproSolidAssignment.Interfaces;
using WiproSolidAssignment.Models;

namespace WiproSolidAssignment.Factories
{
    public class DocumentFactory
    {
        public static IDocument Create(string type)
        {
            return type.ToLower() switch
            {
                "pdf" => new PdfDocument(),
                _ => throw new ArgumentException("Invalid Type")
            };
        }
    }
}