   M S B A M L   `   `   `  ����V  RSystem Retail Operation POS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:System_Retail_Operation_POSSystem_Retail_Operation_POS  5   	   ,    &System_Retail_Operation_POS.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:System_Retail_Operation_POS     5   	     � Icon$  Asset/Icono.png��5   	    � WindowState$ 	Maximized=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � Title$ 
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $
��181* �6   �� 5      $	��19* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $%��System Retail Operation Manager��6   $��Center=�6;   $��Center=�6V   �� 5   
   $��1��6>   $��1��6N   ��6   �� *CurrentViewModel+6N   �� 5   
   $��0��6   $��1��6!   $��10,10,10,10q�6.   ._�5      �� .+�5      �� -   5        .@�5      �� $	��POS��6"   
 � Tag$ Tenter��60   �� 5      $��Product��6"   $ Product��64   �� 5      $
��Menu��6"   �� 5       $
��Menu��6"   �� 5!      $
��Menu��6"   �� 5"      $
��Menu��6"   �� 5#      $
��Menu��6"   5$      5%      5&      5'      5(      