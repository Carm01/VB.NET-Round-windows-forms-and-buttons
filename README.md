# VB.NET x64
# Windows forms with Round Form design and rounded buttons

- Original creator https://www.youtube.com/watch?v=Niu1w4CEIC4
- Original Code: https://rjcodeadvance.com/crear-formulario-de-bordes-redondeados-suaves-c-winforms/

This is a slight variation from https://rjcodeadvance.com/ the original code does not seem to exist so this is my slight variation (I can't find it at least; giving where credit is due).

The Nuget packages also added to the project for smooth round button designs, as everything I found seems do rely on redrawing the original buttons and adding radius/arcs was pixelated and or unevenly applied for smaller buttons.

Button Nuget Package: CButtonLib 
<br />
Button archive location: https://www.codeproject.com/Articles/26622/Custom-Button-Control-with-Gradient-Colors-and-Ext
<br />
The button will show up as a new section called CButton at the top of your choices as shown in the screenshots below

I had to add a Nuget package called Costura.Fody as this will allow the 
additional DLL for the smooth round buttons to embed in the exe so there
 is no need for all other kinds of libraries floating around and to only
 get lost. That is built into the project so no need to go and install 
it. Compile it like a normal app and get the exe from the BIN folder.
> [!important]  
If you build this from scratch and use Costura.Fody, in order to embed all the resourceferences then you will do the following:
>
> You will go into your .vbproj file and add \<Reference Include="mscorlib" /> right above the line where \<Reference Include="System" /> is located. as shown below.
<img src="https://github.com/Carm01/VB.NET-Round-windows-forms-and-buttons/blob/master/RoundFormCornerImages/notepad++_e2MrSzjqA6.png">

> [!important]  
> #### You will have to restore the nuget packages under the nuget packet manager! You will not be able to run the project without restoring them.
> In Visual studio under the TOOLS menu Choose "NuGet Package Manager" -> "Manage NuGet Packages for Solution" You will see a pop up that says "Some Nuget Packages are missing for this solution. Click to Restore from you online package sources"
>
> Here is the screenshot and it is below too: https://github.com/Carm01/VB.NET-Round-windows-forms-and-buttons/blob/master/RoundFormCornerImages/RestoreNuget.png
>
> #### Once you do that build the solutions and all your erros go away!

<br />
<br />
<img src="https://github.com/Carm01/VB.NET-Round-windows-forms-and-buttons/blob/master/RoundFormCornerImages/VSDesignerWindowView.png">

Design View with Toolbar and CButton Choices.
<br />
<br />
<br />
<img src="https://github.com/Carm01/VB.NET-Round-windows-forms-and-buttons/blob/master/RoundFormCornerImages/VSDesignerWindowView2.png">
<br />
Shows what the form actually looks like running.
<br />
<br />
<br />
<img src="https://github.com/Carm01/VB.NET-Round-windows-forms-and-buttons/blob/master/RoundFormCornerImages/RestoreNuget.png">
<br />
Restoring the NuGet Packages.
