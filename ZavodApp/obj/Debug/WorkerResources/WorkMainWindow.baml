   M S B A M L   `   `   `  ����C  ?ZavodApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AA  5   	   C&clr-namespace:ZavodApp.WorkerResourcesZavodApp.WorkerResources  5   	   -    'ZavodApp.WorkerResources.WorkMainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	    behaclr-namespace:A     5   	   8local&clr-namespace:ZavodApp.WorkerResources     5   	     � Title$  ZavodApp��5	   	   $	��450��6   $	��800��6'    � 
ResizeMode$ NoResize=�5
   
    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5       	  Icons �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius	 �� Triggers
 :� RoutedEvent �� TargetProperty g� Duration	 t� To�� 5   
   %  &	        �� 5      " ��6"   .�5      ��  �@�OverridesDefaultStyle . 6:   �� 5       � ��
 ���� 6/   �� 5       � �� 5      �� 5      " ��6*   .R�5      �� $��Border��67   $ 20��6%   #��z��6E   ._�5   "   �� $��Center=�63   $��Center=�6P   5      	 5      :� 5   "   $
 
MouseEnter��6/   .[�5   &   �� .��5   *   �� .��5   .   t� $ Margin�6A   $ 	0:0:0.100D�6d   $ 2,2,2,2X�6y   5   +   5   '   5   #   :� 5   "   $
 
MouseLeave��6/   .[�5    &   �� .��5!   *   �� .��5"   .   t� $ Margin�6A   $ 	0:0:0.100D�6d   $ 1,1,1,1X�6y   5#   +   5$   '   5%   #   :� 5&   "   $
 PreviewMouseDown��6/   .[�5'   &   �� .��5(   *   �� .��5)   .   t� $ Margin�6A   $ 	0:0:0.100D�6d   $ 4,4,4,4X�6y   5*   +   5+   '   5,   #   :� 5-   "   $
 PreviewMouseUp��6/   .[�5.   &   �� .��5/   *   �� .��50   .   t� $ Margin�6A   $ 	0:0:0.100D�6d   $ 0,0,0,0X�6y   51   +   52   '   53   #   55      57      58      59      .��5<      � -   5         �Name$ MainGrid��5<       � ColumnDefinitions 5=   
   �� 5>      $��50 �6   �� 5?      .+�5B   
   clr-namespace:AA  6@    � 6
    behaclr-namespace:A     6@   -   5          �Name$ 	MainFrame��5B   ]   $��1��6     � NavigationUIVisibility$ Hidden=�6    6]   �� 5D   
   -   5         ��Name$ ButtonPanel��5D      $��0��6*    �� Orientation$ Vertical=�6:   
�������.+�5E      �� $��28��6   $��35��6!   $��Center=�6,   $��Center=�6J   $��0,20,0,0q�6e   ._�5F      �� -   5         � Cursor$
 Hand��5F      #��[  6'   .��5G      �� $ 
Horizontal=�6!   .+�5H      �� ��5I      �� 5J   "   " ��6(   .�5K   &   ��  � ��$ Resources/news-icon.png��6?    �� Triggers 5L   &   �� 5M   *    �� Binding 66   ��  �� Path$ IsMouseOver� �� ElementName$
 Cart�� �� Value True6m   .a�5N   .   ��  � ��$ Resources/news-icon.png��6G   5O   +   �� 5P   *    66   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" �� �� AncestorLevel$ 1��$ 	IsPressed� True6�   .a�5Q   .   ��  � ��$ Resources/news-icon.png��6G   5R   +   5T   #   5V      5W      5X      5Y      �� 5Z      $��28��6   $��35��6!   $��Center=�6,   $��Center=�6K   $��0,20,0,0q�6f   ._�5[      �� -   5        $
 Hand��5[      #��[  6'   .��5\      �� $ 
Horizontal=�6!   .+�5]      �� ��5^      �� 5_   "   " ��6(   .�5`   &   ��  � ��$ Resources/tabel-icon.png��6?    5a   &   �� 5b   *    66   �� $ IsMouseOver�$
 Cart�� True6m   .a�5c   .   ��  � ��$ Resources/tabel-icon.png��6G   5d   +   �� 5e   *    66   ��  �� *FindAncestor+" ��$ 1��$ 	IsPressed� True6�   .a�5f   .   ��  � ��$ Resources/tabel-icon.png��6G   5g   +   5i   #   5k      5l      5m      5n      �� 5o      $��28��6   $��35��6!   $��Center=�6,   $��Center=�6K   $��0,20,0,0q�6f   ._�5p      �� -   5        $
 Hand��5p      #��[  6'   .��5q      �� $ 
Horizontal=�6!   .+�5r      �� ��5s      �� 5t   "   " ��6(   .�5u   &   ��  � ��$ Resources/work-icon.png��6?    5v   &   �� 5w   *    66   �� $ IsMouseOver�$
 Cart�� True6m   .a�5x   .   ��  � ��$ Resources/work-icon.png��6G   5y   +   �� 5z   *    66   ��  �� *FindAncestor+" ��$ 1��$ 	IsPressed� True6�   .a�5{   .   ��  � ��$ Resources/work-icon.png��6G   5|   +   5~   #   5�      5�      5�      5�      �� 5�      $��28��6   $��35��6!   $��Center=�6,   $��Center=�6K   $��	0,230,0,0q�6f   ._�5�      �� -   5        $
 Hand��5�      #��[  6'   .��5�      �� $ 
Horizontal=�6!   .+�5�      �� ��5�      �� 5�   "   " ��6(   .�5�   &   ��  � ��$ Resources/quit.png��6?    5�   &   �� 5�   *    66   �� $ IsMouseOver�$
 Cart�� True6m   .a�5�   .   ��  � ��$ Resources/quit.png��6G   5�   +   �� 5�   *    66   ��  �� *FindAncestor+" ��$ 1��$ 	IsPressed� True6�   .a�5�   .   ��  � ��$ Resources/quit.png��6G   5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      