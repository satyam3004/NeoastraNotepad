   M S B A M L   `   `   `  ����J  FNeoastraNotepad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:NeoastraNotepadNeoastraNotepad  5   	   ;"clr-namespace:NeoastraNotepad.ViewNeoastraNotepad.View  5   	        NeoastraNotepad.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:NeoastraNotepad     5   	   9
viewmodels"clr-namespace:NeoastraNotepad.View     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � DataContext 5
      (   "NeoastraNotepad.View.HomePageModel  5   
   .��5      ]� $��1q�6   .+�5   
   o� $	��Top=�6   @�5      m� 5      $
��File��6    6)   �� *File+.@�5      m� $	��New��6    m� Command 6,   �� *New+m� 5      $
��Open��6    6-   �� *Open+m� 5      $
��Save��6    6-   �� *Save+m� 5      $��Save as��6    60   �� *SaveAs+5      5      ]� 5      .+�5   
   �� $��Bottom=�6    5      �� *File.Notepad+��5      �� *
FilePath+�� 5      $	��Top=�6   " �� VerticalScrollBarVisibility$ Visible=�5        �� AcceptsReturn .  �� 
AcceptsTab .  5!      �� *Editor+��5$      �� *Document.Text+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5%      5&      5'      