   M S B A M L   `   `   `  ����C  ?ToursApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ToursAppToursApp  5          ToursApp.AddEditPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:ToursApp     5        N� Title$  AddEditPage��5	      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $
��200* �6   �� 5      $
��533* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Название��6   $��Center=�6$   $��Center=�6A   6_   �� 5   
   $%��Количество звёзд��6   $��1��6,   $��Center=�69   $��Center=�6T   6s   �� 5   
   $��Страна��6   $��2��6"   $��Center=�6/   $��Center=�6J   6j   �� 5   
    �� 	MaxLength$	 100��6(   $��Center=�68   $��2��6S   $��
218,0,10,0q�6g   ��6   �� *Name+6g   �� 5   
   $��1��61   $	��175��6>   $��Center=�6J   $
��Left=�6e   $��2��6�   $��	218,0,0,0q�6�   ��6   �� *CountOfStars+6�   �� 5   
   -   5         ��Name$ ComboCoutries��5   B   $��2��65    �� DisplayMemberPath$
 Name��6Y   $��Center=�6r   $��2��6�   $��
218,0,10,0q�6�    �� SelectedItem 6   �� *	Country+6�   �� 5   
   -   5        $��BtnSave��5   F   $��Сохранить��6   $��2��6%   $��4��69   6m   5      5       