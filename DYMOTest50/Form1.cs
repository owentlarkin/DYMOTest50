using DymoSDK.Implementations;
using System;
using System.Text;
using System.Windows.Forms;

namespace DYMOTest50
{
 public partial class Form1 : Form
 {
  public static string Format_exception(Exception e, string header = "Error")
  {
   var erm = new StringBuilder();
   erm.Append(header);
   erm.Append("\n");


   if (e is AggregateException)
   {
    AggregateException ae = e as AggregateException;
    erm.Append("One or more errors have occured in a background process." + "\n");
    foreach (var e1 in ae.Flatten().InnerExceptions)
    {
     erm.Append("\n");
     erm.Append(e1.Message);
     if (e1.StackTrace is object)
     {
      erm.Append("\n" + "Stack Trace:" + "\n");
      erm.Append(e1.StackTrace);
     }
    }
   }
   else
   {
    erm.Append(e.Message);
    if (e.StackTrace is object)
    {
     erm.Append("\n" + "Stack Trace:" + "\n");
     erm.Append(e.StackTrace);
    }
   }

   return erm.ToString();
  }

  public Form1()
  {
   InitializeComponent();
   try
   {
    DymoSDK.App.Init();
    var Dsl = DymoLabel.Instance;
    TB1.Text = Dsl.ToString();
   }
   catch (Exception Ex)
   {
    RTB1.Text = Format_exception(Ex);
   }
  }

 }
}
