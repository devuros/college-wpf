   M S B A M L   `   `   `  ����I  EAddressBookMoj, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AddressBookMojAddressBookMoj  5   	       AddressBookMoj.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   .localclr-namespace:AddressBookMoj     5   	     � Title$  
MainWindow��5   	   $	��700��5   	   $
��1050��6   .��5      �  � RowDefinitions 5   
   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   o� $��0��6   .@�5      m� $
��File��6   .@�5      m� $
��Exit��6    m� Command 6)   �� *ExitCommand+5      m� 5      $��_Perons��6   .@�5      m� $
��_Add��6    6)   �� *
AddCommand+m� 5      $��_Remove��6    6,   �� *RemoveCommand+5      5      `� 5   
   $��1��6   .�5      c� .@�5      �� .��6   Open6   �� 5      .��6   	Save as6"   5      5      � 5   
   $��2��6    � ColumnDefinitions 5       �� 5!      $	��200��6#   $
��Auto �62   �� 5"      $��* �6$   .+�5%      �� $��0��6   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6S   ��6&   ��  �� Path$ Adresar.Persons���5&      �� 5'      .R�5(      ��  �� Orientation$ Vertical=�6%   .+�5)      �� $ 
Horizontal=�6)   .+�5*   "   A� 
���   �$��10��67   $��10��6B   $��3q�6N   6[   �� 5+   "   ��6,   �� $
 Name�6I   5,      �� 5-      ��6(   �� $ 	Birthdate�6J   5.      5/      51      � 52      $��1��6    53      �� 54      $
��Auto �6%   �� 55      $
��Auto �6%   �� 56      $
��Auto �6%   �� 57      $
��Auto �6%   �� 58      $
��Auto �6%   �� 59      $��* �6%    5;      �� 5<      $
��Auto �6'   �� 5=      $��* �6'   .+�5A      �� $��0��6   $��0��6)   .��69   Name:6@   �� 5B      $��1��6   $��0��6)   .��69   
Birthdate:6E   �� 5C      $��2��6   $��0��6)   .��69   	Height:6B   �� 5D      $��3��6   $��0��6)   .��69   Age:6?   �� 5E      $��4��6   $��0��6)   .��69   	Gender:6B   �� 5G      $��0��6   $��1��6+   ��6;   �� $ Adresar.Persons/Name�6h   (  "System.Windows.Controls.DatePicker  5H      $��1��6!   $��1��6.      SelectedDate 6>   �� $ Adresar.Persons/Birthdate�6x   �� 5I      $��2��6   $��1��6+   ��6;   �� $ Adresar.Persons/Height�6j   �� 5J      $��3��6    $��1��6-   ��6=   �� $ Adresar.Persons/Age�6i   �� 5K      $��4��6   $��1��6,      AddressBookMoj.Gender   Genders#��Z 5L      	 �� SelectedItem	 5M      �� $ Adresar.Persons/Gender�6V   &   System.Windows.Controls.DataGrid  5O      $��5��6   $��0��6,   $��2��6<   
   AutoGenerateColumns
 .  ��5P      �� $ Adresar.Persons/Adrese�   Columns 5Q      0  *System.Windows.Controls.DataGridTextColumn  5R      ,  &System.Windows.Controls.DataGridColumn   Header$ 
StreetName��62      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6P   �� $ StrName�  5S      $	 No.��61   $
 Auto 6>    6K   �� $ 	StrNumber�5U      5W      5Y      �� 5Z   
   $��3��6   .@�5[      �� ��6   �� $ Adresar.Persons.Count� �� StringFormat$ Persons count: {0}��6i   5\      5^      5_      