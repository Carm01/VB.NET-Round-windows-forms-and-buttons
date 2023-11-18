# VB.NET x64
# Windows forms with Round Form design and rounded buttons

- Original creator https://www.youtube.com/watch?v=Niu1w4CEIC4
- Original Code: https://rjcodeadvance.com/crear-formulario-de-bordes-redondeados-suaves-c-winforms/

This is a slight variation from https://rjcodeadvance.com/ the original code does not seem to exist so this is my slight variation (I can't find it at least; giving where credit is due).

> [!important]  
> #### You will have to restore the nuget packages under the nuget packet manager! They are not pushed to the repository by visual studio

I had to add a Nuget package called Costura.Fody as this will allow the additional DLL for the smooth round buttons to embed in the exe so there is no need for all other kinds of libraries floating around and to only get lost. That is built into the project so no need to go and install it. Compile it like a normal app and get the exe from the BIN folder.

The Nuget packages also added to the project for smooth round button designs, as everything I found seems do rely on redrawing the original buttons and adding radius/arcs was pixelated and or unevenly applied for smaller buttons.

Button Nuget Package: CButtonLib 
<br />
Button archive location: https://www.codeproject.com/Articles/26622/Custom-Button-Control-with-Gradient-Colors-and-Ext
<br />
The button will show up as a new section called CButton at the top of your choices as shown in the screenshot.
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
