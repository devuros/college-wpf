   M S B A M L   `   `   `  ����I  EAddressBookMoj, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AddressBookMojAddressBookMoj  5   	   !    AddressBookMoj.PersonDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   .localclr-namespace:AddressBookMoj     5   	     � Title$  New Person Dialog��5   	   $	��300��5   	   $	��300��6   .��5      �  � RowDefinitions 5   
   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   .��6-   Name:64   �� 5   
   $��1��6   $��0��6   .��6-   
Birthdate:69   �� 5   
   $��2��6   $��0��6   .��6-   	Height:66   �� 5   
   $��3��6   $��0��6   .��6-   	Gender:66   �� 5   
   $��0��6   $��1��6   ��6/   ��  �� Path$ Adresar.Persons/Name�6\   (  "System.Windows.Controls.DatePicker  5   
   $��1��6   $��1��6"      SelectedDate 62   �� $ Adresar.Persons/Birthdate�6l   �� 5   
   $��2��6   $��1��6   ��6/   �� $ Adresar.Persons/Height�6^   �� 5   
   $��3��6   $��1��6       AddressBookMoj.Gender   Genders#��Z 5       �� SelectedItem 5       �� $ Adresar.Persons/Gender�6V   &   System.Windows.Controls.DataGrid  5"   
   $��4��6   $��0��6    $��2��60      AutoGenerateColumns .  ��5#      �� $ Adresar.Persons/Adrese�   Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
StreetName��6&   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6:   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� $ StrName�  5&      $		 No.��6%   $

 Auto 62    6?   �� $ 	StrNumber�5(      �� 5*   
   $��6��6   $��0��6"   $��2��62    �� Orientation$ 
Horizontal=�6F   $��Center=�6_   .+�5+      �� -   5        $��btnOk��5+   J    �� 	IsDefault . $��20��6&   $	��Top=�62   .��6k   OK6o   �� 5,       �� IsCancel . .��6%   Cancel6-   5-      5/      50      