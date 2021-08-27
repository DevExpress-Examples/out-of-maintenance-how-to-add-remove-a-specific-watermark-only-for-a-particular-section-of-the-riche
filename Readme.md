<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128609304/13.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4901)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs)
<!-- default file list end -->
# How to add (remove) a specific watermark only for a particular section of the RichEditControl's document


<p>This example extends the approach demonstrated in the following example: <a href="https://www.devexpress.com/Support/Center/p/E4184">How to add a watermark with a text or image to the document</a></p><p>The main idea of the approach demonstrated in this sample is to add/remove a watermark only for a currently selected section.</p><p>For this purpose, two items were added to the RichEditControl's context menu:</p><p>- "Add watermark". This item click results in opening a file dialog to select an image. This image will be inserted as a watermark for a currently selected section.</p><p>- "Remove watermark". This item click results in deleting the watermark only from the currently selected section.</p>

<br/>


