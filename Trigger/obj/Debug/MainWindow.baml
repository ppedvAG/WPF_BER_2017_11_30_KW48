   M S B A M L   `   `   `  ����B  >Trigger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TriggerTrigger  5   	       Trigger.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Trigger     5   	     � Title$  
MainWindow��5   	   $��313.977��6   $��413.833��6-   .��5	      �� $��10q�6   .+�5
   
   �� ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value$
 Nein��60   �� 5       � ��
 �  ��63    �� Triggers 5      �� 5       �� Binding 6&   �� *	BoolVal+ �� Value True6B   .a�5      ��  � ��$ Ja��68   �� 5       � ��
 � � �6;   5      5      5      �� 5   
   -   5        $��Ändere Eigenschaft��5      6.   �� 5   
   $��10q�6   �� 5   
   $/��)Möchtest du eine Gehaltserhöhung haben?��6   �� 5   
   -   5         ��Name$ cvsMain��5      
����·�$	��200��6<   .+�5      �� -   5         ��Name$ btnJa��5   J   $��80��6   $��10q�6    $��Ja��6,   	 �� Left$	 20��69   
 � Triggers
 5      :� 5        :� RoutedEvent$ 
MouseEnter��6#   [�5!      �� 5"      .��5#   "   �� .��5$   &   W�  �� 
TargetName$ btnJa��66    �� TargetProperty$ (Canvas.Left)�5%   6   	 W� To$	 600X�5&   6    g� Duration$ 0:0:1D�5'   6   5(   #   5)      5+      5-      �� 5.      $��80��6   $��10q�6    $
��Nein��6,   $		 120��6;   
 5/      :� 50      $ 
MouseEnter��6#   [�51      �� 52      .��53   "   �� .��54   &   W� $ btnJa��66   $ (Canvas.Left)�55   6   $ 20X�56   6   $ 0:0:1D�57   6   �� 58   &   $ cvsMain��65   $( "Background.(SolidColorBrush.Color)�59   5   	 �� To$ 	PaleGreenX�5:   5   $ 0:0:10D�5;   5   5<   #   5=      5?      5A      5B      5D      5E      