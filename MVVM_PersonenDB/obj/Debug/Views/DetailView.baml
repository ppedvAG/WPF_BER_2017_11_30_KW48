   M S B A M L   `   `   `  ����J  FMVVM_PersonenDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MVVM_PersonenDB.ViewsMVVM_PersonenDB.Views  5   	   &     MVVM_PersonenDB.Views.DetailView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:MVVM_PersonenDB.Views     5   	   -   5          �Name$  	wndDetail��5	   )    � Title$ 
DetailView��5   	   $��170.689��6   $��263.218��6-    
  styWnd#��[  5	   	   .��5
      � $��5q�6    � ColumnDefinitions 5   
   �� 5   
   $
��Auto �6   �� 5   
   $��* �6    � RowDefinitions 5   
   �� 5   
   $
��Auto �6   �� 5   
   $
��Auto �6   �� 5   
   $
��Auto �6   �� 5   
   $��* �6   .+�5   
   �� $��Vorname��6   $��0��6#   $	��0,4q�60   �� 5   
   $��Nachname��6   $��1��6$   $	��0,4q�61   �� 5   
   $��Geburtsdatum��6   $��2��6(   $��0,4,8,4q�65   �� 5   
   $��1��6   $��0��6"   $	��0,4q�5      ��5      �� *aktuellePerson.Vorname+ �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��1��6   $��1��6"   $	��0,4q�5      ��5      �� *aktuellePerson.Nachname+ . $ PropertyChanged=�(  "System.Windows.Controls.DatePicker  5   
   $��1��6   $��2��6%      SelectedDate 5       �� *aktuellePerson.Geburtsdatum+ . $ PropertyChanged=�� 5"   
   $��3��6   $��2��6!   $��Right=�65   $	��0,4q�6Q   .+�5#      �� $��OK��6   $��80��6"   $	��2,1q�6-   ��5$      �� *OkCmd+��6/   ��  �� ElementName$ 	wndDetail���� 5%      $��Abbruch��6   $��80��6'   $	��2,1q�62    �� IsCancel . 6?   5&      5(      5)      