using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xceed.Words.NET;
using iText.Layout;
using iText.Layout.Element;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using Xceed.Document.NET;

const string FullPath = "C:\\Users\\pava-\\Desktop\\CV\\";
const string NameTmpIn = "Can_CoverLetter_Tmp.pdf";
const string NameTmpOut = "Can_CoverLetter_Tmp1.pdf";

ConvertPdfToDocx(Path.Combine(FullPath, NameTmpIn), Path.Combine(FullPath, "tmp.docx"));

var replacements = new Dictionary<string, string>();
replacements.Add("[ClientName]", "Pavel Nurgaliev");
ReplaceWords(Path.Combine(FullPath, "tmp.docx"), replacements);

ConvertDocxToPdf(Path.Combine(FullPath, "tmp.docx"), Path.Combine(FullPath, NameTmpOut));

static void ConvertPdfToDocx(string pdfFilePath, string docxFilePath)
{
    // iTextSharp for PDF parsing
    using (PdfReader pdfReader = new PdfReader(pdfFilePath))
    {
        using (PdfDocument pdfDocument = new PdfDocument(pdfReader))
        {
            // DocX for DOCX creation
            using (DocX doc = DocX.Create(docxFilePath))
            {
                for (int pageNum = 1; pageNum <= pdfDocument.GetNumberOfPages(); pageNum++)
                {
                    iText.Kernel.Geom.Rectangle pageSize = pdfDocument.GetPage(pageNum).GetPageSize();

                    // Create a new paragraph for each page
                    var paragraph = doc.InsertParagraph();

                    // Extract text from PDF and add it to the paragraph
                    string text = PdfTextExtractor.GetTextFromPage(pdfDocument.GetPage(pageNum));
                    throw new Exception(text);
                    paragraph.InsertText(text);

                    // Add a page break after each page (optional)
                    if (pageNum < pdfDocument.GetNumberOfPages())
                        paragraph.InsertPageBreakAfterSelf();
                }

                // Save the DocX document
                doc.Save();
            }
        }
    }
}

static void ReplaceWords(string docxFilePath, Dictionary<string, string> replacements)
{
    using (DocX doc = DocX.Load(docxFilePath))
    {
        // Iterate through paragraphs and replace the old word with the new word
        foreach (var paragraph in doc.Paragraphs)
        {
            foreach (var itemKvp in replacements)
            {
                paragraph.ReplaceText(itemKvp.Key, itemKvp.Value);
            }
        }

        // Save the modified document
        doc.SaveAs(docxFilePath);
    }
}

static void ConvertDocxToPdf(string docxFilePath, string pdfFilePath)
{
    // Load DOCX document using Xceed.Words.NET
    using (DocX doc = DocX.Load(docxFilePath))
    {
        // Create a new PDF document using iTextSharp
        using (PdfWriter pdfWriter = new PdfWriter(pdfFilePath))
        {
            using (PdfDocument pdfDocument = new PdfDocument(pdfWriter))
            {
                // Iterate through paragraphs in DOCX and add them to PDF
                foreach (var paragraph in doc.Paragraphs)
                {
                    pdfDocument.AddNewPage();
                    using (iText.Layout.Document pdfDoc = new iText.Layout.Document(pdfDocument))
                    {
                        pdfDoc.Add(new iText.Layout.Element.Paragraph(paragraph.Text));
                    }
                }
            }
        }
    }
}