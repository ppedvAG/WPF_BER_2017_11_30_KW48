   M S B A M L   `   `   `  ����I  EValueConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ValueConverterValueConverter  5   	       ValueConverter.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ValueConverter     5   	     � Title$  
MainWindow��5   	   $��457.228��6   $��325.369��6-    � 	Resources 5	      +  %ValueConverter.DoubleToBrushConverter   double2brush-  'ValueConverter.DoublesToBrushMConverter  doubles2brush��%:   &	        &	        5
   
   6'     5   
   6)   5      .��5      �� $��5q�6   .+�5   
   �� $��1q�6   
���   �$	��100��69   $	��100��6F   $��10q�6R   ._�5      �� -   5         ��Name$ 	rctOutput��5   1   $	��100��6   $	��100��6%   ��5      ��  �� ElementName$ sldInput�� �� Path$ Value� �� UpdateSourceTrigger$ PropertyChanged=� �� 	Converter# [  5      �� 5   
   -   5         ��Name$ sldInput��5       � Minimum$ 0Q�6#   	 � Maximum$		 255Q�6/   $��10q�6=   �� 5   
   �� 5   
   $	��100��6   $	��100��6!   $��10q�6-   ��5      `� 5      
 `� 	Converter#
 [ 6   .1�5      �� $
 sldR��6   $ Value�61   $ PropertyChanged=�6>   �� 5      $
 sldG��6   $ Value�61   $ PropertyChanged=�6>   �� 5      $
 sldB��6   $ Value�61   $ PropertyChanged=�6>   5      5      �� 5!   
    �� Orientation$ 
Horizontal=�6   .+�5"      �� $	��R: ��6   $��Center=�6#   $
��Bold"�5#      $��20��6*   
���  ��65   �� 5$      -   5        $
 sldR��5$      $ 0Q�6#   $		 255Q�6/   $��10q�6=   $	��200��6I   �� 5%      $��60��6   $��5q�5'      $��Center=�6!   ��5&      �� $
 sldR��$ Value�$ PropertyChanged=�5'   !   5(      �� 5*   
   $ 
Horizontal=�6   .+�5+      �� $	��G: ��6   $��Center=�6#   $
��Bold"�5,      $��20��6*   
��� � �65   �� 5-      -   5        $
 sldG��5-      $ 0Q�6#   $		 255Q�6/   $��10q�6=   $	��200��6I   �� 5.      $��60��6   $��5q�50      $��Center=�6!   ��5/      �� $
 sldG��$ Value�$ PropertyChanged=�50   !   51      �� 53   
   $ 
Horizontal=�6   .+�54      �� $	��B: ��6   $��Center=�6#   $
��Bold"�55      $��20��6*   
����  �65   �� 56      -   5        $
 sldB��56      $ 0Q�6#   $		 255Q�6/   $��10q�6=   $	��200��6I   �� 57      $��60��6   $��5q�59      $��Center=�6!   ��58      �� $
 sldB��$ Value�$ PropertyChanged=�59   !   5:      5;      5<      