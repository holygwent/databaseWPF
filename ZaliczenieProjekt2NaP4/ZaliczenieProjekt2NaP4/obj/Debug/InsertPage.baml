   M S B A M L   `   `   `  ����Q  MZaliczenieProjekt2NaP4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ZaliczenieProjekt2NaP4ZaliczenieProjekt2NaP4  5   	   '    !ZaliczenieProjekt2NaP4.InsertPage   5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5	   	   @d2http://schemas.microsoft.com/expression/blend/2008     5
   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ZaliczenieProjekt2NaP4     5   	      MaterialDesignBody#���   5   	     MaterialDesignPaper#���  5   	   $��Medium"�5   	   $��14(�5   	     � Title$  
InsertPage��5   	   $	��300��6   $	��450��6)    � WindowStartupLocation$ CenterScreen=�5      ��5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension   � 	Resources 5       
 Center �� Property �� Value  Box��%�   &	       &	 j     �� 5   
   .�5      ��  � ��$ Center=�6>   �� 5       � ��$ Center=�6<   5      �� 5   
   .�5      ��  � ��$ 10q�6/   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5    
   �� 5!      $��* �6   �� 5"      $��* �6   �� 5#      $��* �6   �� 5$      $��* �6   �� 5%      $��* �6   .+�5'   
   �� $��Student��6   $��0��6#   $��2��60   #��[ 6D   $��20(�6d   �� 5(   
   $��1��6   $��0��6"   $��Name:��62   #��[ 6?   �� 5)   
   -   5         ��Name$ TextBoxName��5)      $��1��6(   $��1��65   #��[ 6E   �� 5*   
   $��2��6   $��0��6"   $��Surname:��62   #��[ 6B   �� 5+   
   -   5        $ TextBoxSurname��5+      $��2��6+   $��1��68   #��[ 6H   �� 5,   
   $��3��6   $��0��6"   $��Course:��62   #��[ 6A   �� 5-   
   -   5         ��Name$ ComboBoxCourse��5-      $��3��6+   $��1��68   $��	10,0,10,0q�6H   @�5.      �� 5/      .��6   C#6#   �� 50      .��6   Java6%   �� 51      .��6   PHP6$   �� 52      .��6   HTML6%   54      �� 55   
   -   5        	 ��Name$	 	insertBtn��55      $��4��6$   $��2��61   $��Insert��6E   $��	10,0,10,0q�6n   58      59      