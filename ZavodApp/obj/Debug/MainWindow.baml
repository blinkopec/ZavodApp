   M S B A M L   `   `   `  ����C  ?ZavodApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ZavodAppZavodApp  5   	       ZavodApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ZavodApp     5   	     � Title$  ZavodApp��5   	   $	��400��6   $	��400��6'    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	   .��5      � -   5         �Name$ MainGrid��5      
������� � RowDefinitions 5   
   �� 5      $	��150 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $	��100 �6   .+�5   
   �� $��Вход��5      $
��Bold"�5      $��25(�5      $��Center=�5      $��Bottom=�5      $��0��5       � 5"   
   $��1��6    � ColumnDefinitions 5#      �� 5$      $	��125 �6#   �� 5%      .+�5(      �� $��0��6   $��Right=�5)      $��
Логин��5*      $
��Bold"�5+      5,      �� 5/   
   -   5         ��Name$ LoginBox��5/      $��2��50      $��Center=�51      $	��235��52      � 54   
   $��3��6    55      �� 56      $	��130 �6#   �� 57      .+�5:      �� $��0��6   $��Пароль��5;      $��Right=�5<      $
��Bold"�5=      5>      G� 5A   
   -   5         G�Name$ PsswdBox��5A      $��4��5B      $��Center=�5C      $	��235��5D      �� 5G   
   -   5         ��Name$ 
ErrorLabel��5G      $��6��5H      $��Center=�5I      
���  ��5J      �� 5L   
   -   5        	 ��Name$	 LoginButton��5L      $��7��5M      $��Center=�5N      $��Bottom=�5O      $��Вход��5P      $��25��5Q      
������ 
������ ��5T      �� 5U      
 �� 
TargetType"
 ��6   .�5V      ��  �� Property � �� �� Value
 � � �63   �� 5W       � �� 5X      �� 5Y       �� 
TargetType" ��6.   .R�5Z   "   �� #��z��6)   ._�5[   &   �� $��Center=�67   $��Center=�6T   5\   #   5]      5_       �� Triggers 5`      P� 5a       P� Property �@J�IsMouseOver P� Value . . �5b      ��  � ��
 ����6;   �� 5c       �@J�RenderTransformOrigin$ 0.5, 0.5&�6F   �� 5d       � z� 5e   "   �� 5f   &    �� ScaleX$	 1.2Q�65    �� ScaleY$	 1.2Q�6B   5h      5i      P� 5j       � �� . . �5k      ��  � z� 5l   "   �� 5m   &   $ 1Q�65   $ 1Q�6@   5o      5p      5r      5t      5u      5v      