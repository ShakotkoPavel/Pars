   M S B A M L   `   `   `  ����A  =Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ParserParser  5   	       Parser.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TXceed.Wpf.Toolkit, Version=3.2.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	    localclr-namespace:Parser  5   	     � Title$  Parser��5	   	   $	��350��6   $	��300��6%   
���OO/�.��5
      � $��0,0,0,0q�6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ listBox��5      $��0,45,0,0q�6#   $��2��65   �� 5   
   -   5         ��Name$ 
labelStart��5      $��Start page:��6$   $
��Left=�6:   $��19��6U   $��2,2,0,0q�6a   $	��Top=�6r   $��62��6�   $��0q�6�   �� 5   
   -   5        $ labelEnd��5      $��	End page:��6"   $
��Left=�66   $��19��6Q   $��2,23,0,0q�6]   $	��Top=�6o   $��62��6�   $��0q�6�   %  Xceed.Wpf.Toolkit.IntegerUpDown  5   
   -   5          Name$ 	startPage��5      $��	65,2,24,0q�60   $��19��6C   $	��Top=�6O     5   
   -   5        $ endPage��5      $��
65,23,24,0q�6.   $��19��6B   $	��Top=�6N   �� 5   
   -   5         ��Name$ buttonStart��5      $��Start��6&   $��	26,2,10,0q�66   $	��Top=�6I   $��19��6a   $��0q�6m   $��1��6�   �� 5   
   -   5        $ 	buttonEnd��5      $��Abort��6$   $��
26,23,10,0q�64   $	��Top=�6H   $��19��6`   $��0q�6l   $��1��6�   5      5      