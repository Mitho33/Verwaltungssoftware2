   M S B A M L   `   `   `  ����H  DWpfXmlDataSEt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfXmlDataSEtWpfXmlDataSEt  5   	       WpfXmlDataSEt.Ausleihe   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfXmlDataSEt     5   	     � Title$  Ausleihe��5   	   $
��auto��6   $
��auto��6(   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��1.5* �6   6.   �� 5      $��1* �6   6,   .+�5   
   �� 
�������$��0��6%   �� 5   
   
������$��1��6&   �� 5   
   $��Center=�6   $��0��62   $	��360��6B   $��18,30,18,10q�6N   .+�5      �� $��Buchausleihe��6   $
��Left=�6*   $��25(�6E   &   System.Windows.Controls.DataGrid  5      -   5          Name$ datagrid��5      $
��Left=�6*   ��6E   �� *	Buchliste+5      5      �� 5   
   $��1��6   $��35,83,172,186q�6&   .+�5      �� $��Ausleihe��6   
�������6'   �� 5      -   5         ��Name$ 
TbAusleihe��5      
�������$
��Left=�6B   $��44��6]    �� TextWrapping$
 Wrap=�6i   $	��Top=�6~   $	��109��6�   .��6�   .��5      ��  �� ElementName$ datagrid��6    �� Path$ SelectedItem.Person�61   5      �� 5      -   5        $ TbPerson��5      
�������$
��Left=�6@   $��44��6[   $
 Wrap=�6g   $	��Top=�6|   $	��109��6�   .��6�   .��5      �� $ datagrid��6   $ SelectedItem.Person�61   5      (  "System.Windows.Controls.DatePicker  5      -   5          Name$ DpDatum��5      
�������$
��Left=�6A   $��44��6\      Text$  ��6i   $	��Top=�6q   $	��109��6�   5       �� 5"   
   $��1��6   $��131,250,0,10q�6&   .+�5#      �� -   5        	 ��Name$	 CdbAusleihe��5#   (   $��Ausleihe��6   $��80��6=   $��30��6H   6p   �� 5%      -   5        $	 
CdbZurück��5%   &   $��Zurück��6   $��80��69   $��30��6D   6j   5&      �� 5(   
   $��1��6   $	��100��6!   $��60��6-      logo#��[  5)      $��195,30,22,329q�61   5*      5+      5,      