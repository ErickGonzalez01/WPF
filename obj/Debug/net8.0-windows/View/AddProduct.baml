   M S B A M L   `   `   `  ����V  RSystem Retail Operation POS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:System_Retail_Operation_POS.View System_Retail_Operation_POS.View  5   	   1    +System_Retail_Operation_POS.View.AddProduct   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:System_Retail_Operation_POS.View     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5	   	    � Icon$ ../Asset/Icono.png��5
   	    � Title$ Nuevo Producto��5   	   $	��289��6    $	��600��6-   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��0��6"   .+�5      �� $��5q�6    �� Orientation$ 
Horizontal=�6$   .+�5      �� $	��150��6   $��Código de barra:��6$   6A   �� 5      -   5         ��Name$ 
txtBarCode��5   &   $	��300��6   6&   5      �� 5      $��5q�6   $ 
Horizontal=�6$   .+�5      �� $	��150��6   $��Categoría:��6$   6;   �� 5      -   5        $ txtCategory��5   &   $	��300��6   6&   5      �� 5      $��5q�6   $ 
Horizontal=�6$   .+�5       �� $	��150��6   $��Descripción:��6$   6=   �� 5!      -   5        $ txtDescription��5!   &   $	��300��6   6&   5"      �� 5#      $��5q�6   $ 
Horizontal=�6$   .+�5$      �� $	��150��6   $��Precio:��6$   68   �� 5%      -   5        $ txtPrice��5%   &   $	��300��6   6&   5&      5'      �� 5(   
   $��0��6   $��1��6%   .+�5)      �� 
���   �$��2q�6)   $��5q�6=    �� Padding$ 5q�6H   	 �� CornerRadius$	 5��6T   ._�5*      �� .+�5+      �� $ 
Horizontal=�6!   .+�5,      �� $	��150��6    $��Producto padre:��6,   6H   �� 5-      -   5        $ txtParentProduct��5-   .   $	��300��6"   6.   �� 5.      Lorem Ipsom61   5/      �� 50      $ 
Horizontal=�6!   .+�51      �� $	��150��6    $��Cantidad de hijos:��6,   6K   �� 52      -   5        $! txtQuantityProductsChildren��52   .   $	��300��6"   6.   53      54      55      56      ]� 57   
   $��Right=�6   $��2��60   $��0��6=   .+�58      ��    BtnImage#��[  6   $��Cancelar��6:   �� 59      #��[  6   $��Guardar��6:   5:      5;      5<      