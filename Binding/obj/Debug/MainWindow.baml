   M S B A M L   `   `   `  ����B  >Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BindingBinding  5   	       Binding.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Binding     5   	     � Title$  
MainWindow��5   	   $��403.709��6   $��369.139��6-   .��5	      �� .+�5
   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $	��250��6.    � Value 5      �� 5       �� ElementName$ tbxEins��6    �� Path$
 Text�64    �� Mode$ TwoWay=�6@    �� UpdateSourceTrigger$ 	LostFocus=�6N   5      �� 5      -   5         ��Name$ tbxEins��5      $	��100��6'   5      �� 5   
   �� 5   
   $ 
Horizontal=�6   .+�5      �� $ 
Horizontal=�6   $	��250��6.    5      �� 5      $ tbxZwei��6   $
 Text�64   $ OneWay=�6@   $ PropertyChanged=�6N   5      �� 5      -   5        $ tbxZwei��5      $	��100��6'   5      �� 5   
   �� 5   
   $ 
Horizontal=�6   .+�5      �� $ 
Horizontal=�6   $	��250��6.   	 �� TickPlacement$	 BottomRight=�6:   
 �� IsSnapToTickEnabled
 .  5      �� 5      $ tbxDrei��6   $
 Text�64   $ OneWayToSource=�6@   $ PropertyChanged=�6V   5!      �� 5"      -   5        $ tbxDrei��5"      $	��100��6'   5#      �� 5$   
   �� 5%   
   $ 
Horizontal=�6   .+�5&      �� $ 
Horizontal=�6   $	��250��6.   $	 BottomRight=�6:   
 .  5'      �� $ tbxVier��$
 Text�$ OneTime=�$ PropertyChanged=��� 5(      -   5        $ tbxVier��5(      $	��100��6'   $��8��63   5)      �� 5*   
   �� 5+   
   $ 
Horizontal=�6   .+�5,      �� -   5         ��Name$ sldFünf��5.      $ 
Horizontal=�5,      $	��250��6.   $	 BottomRight=�6:   
 .  5-      �� $ tbxFünf��$
 Text�$ TwoWay=�$ Explicit=�5.      �� 5/      -   5        $ tbxFünf��5/      $	��100��6'   $��8��63   �� 50      -   5         ��Name$ 	btnChange��50      $��Übernehmen��6(   6=   51      52      53      