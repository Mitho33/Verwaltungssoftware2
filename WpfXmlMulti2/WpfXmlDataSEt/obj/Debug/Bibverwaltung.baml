   M S B A M L   `   `   `  ����H  DWpfXmlDataSEt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfXmlDataSEtWpfXmlDataSEt  5   	   !    WpfXmlDataSEt.Bibverwaltung   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfXmlDataSEt     5   	     � Title$  Bibverwaltung��5   	   $
��auto��6   $
��auto��6-   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��1.5* �6   6.   �� 5      $��1* �6   6,   .+�5   
   �� 
�������$��0��6%   �� 5   
   
������$��1��6&   �� 5   
   $��Center=�6   $��0��62   $	��360��6B   $��18,30,18,10q�6N   .+�5      �� $��Verwaltung Bibliothek��6   $
��Left=�63   $��25(�6N   &   System.Windows.Controls.DataGrid  5      -   5          Name$ datagrid��5      $
��Left=�6*   ��6E   �� *	Buchliste+5      5      �� 5   
   $��1��6   $��131,250,0,10q�6&   .+�5      �� -   5         ��Name$ CdbHinzufügen��5   *   $��Hinzufügen��6   $��80��6A   $��30��6L   6v   �� 5      -   5        $ CdbLöschen��5   '   $��Löschen��6   $��80��6;   $��30��6F   6m   �� 5      -   5        $ 
CdbZurück��5   &   $��Zurück��6   $��80��69   $��30��6D   6j   5      �� 5   
   $��1��6   $��40,30,167,97q�6(   .+�5      �� -   5         ��Name$
 TbId��5      
�������$
��Left=�6<   $��44��6W   $	��Top=�6d   $	��109��6|   .��6�   .��5      ��  �� ElementName$ datagrid��6    �� Path$ SelectedItem.ID�61   5      �� 5       -   5        $ TbAutor��5       
�������$
��Left=�6?   $��44��6Z    �� TextWrapping$
 Wrap=�6f   $	��Top=�6{   $	��109��6�   .��6�   .��5!      �� $ datagrid��6   $ SelectedItem.Autor�61   5"      �� 5#      -   5        $ TbTitel��5#      
�������$��44��6?   $
��Left=�6K   $
 Wrap=�6f   $	��Top=�6{   $	��109��6�   .��6�   .��5$      �� $ datagrid��6   $ SelectedItem.Titel�61   5%      �� 5&      -   5        $ 
TbSignatur��5&      
�������$
��Left=�6B   $��44��6]   $
 Wrap=�6i   $	��Top=�6~   $	��109��6�   .��6�   .��5'      �� $ datagrid��6   $ SelectedItem.Signatur�61   5(      �� 5)      -	   5        $ TbPerson��5)      
�������$
��Left=�6@   $��44��6[   $
 Wrap=�6g   $	��Top=�6|   $	��109��6�   .��6�   .��5*      �� $ datagrid��6   $ SelectedItem.Person�61    �� Mode$ TwoWay=�6L   5+      (  "System.Windows.Controls.DatePicker  5,      -
   5        	  Name$	 DpDatum��5,      
�������$
��Left=�6A   $��44��6\   
   Text$
  ��6i   $	��Top=�6q   $	��109��6�   5-      �� 5.   
   $��1��6   $	��100��6!   $��60��6-      logo#��[  5/      $��195,30,22,329q�61   50      �� 51   
   -   5        $ 
TbLöschen��51   +   $��1��6   $�� ��6#   $
��Left=�6>   $��33��6Y   $��195,149,0,0q�6e   $
 Wrap=�6z   $	��Top=�6�   $��76��6�   53      54      