   M S B A M L   `   `   `  ����C  ?ZavodApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:ZavodApp.WorkerResources.Pages.TabelPages)ZavodApp.WorkerResources.Pages.TabelPages  5   	   ;    5ZavodApp.WorkerResources.Pages.TabelPages.OrderWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Ilocal7clr-namespace:ZavodApp.WorkerResources.Pages.TabelPages     5   	     � Title$  OrderWindow��5   	   $	��400��6   $	��200��6*    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � 	Resources 5         myTemplate2 �� CornerRadius � RowDefinitions�� 5   
   %�  &	        �� 5      .R�5      �� 
�������$ 8��60   $��0,15,0,0q�6A   ._�5      � $	��100��6   $��40��6'    5      �� 5      �� 5      .+�5      �� $��0��6$   $	��Top=�61   $
��Left=�6J   �� 5      $�Тип: ��6"    �� 5      �6"   �� *
NameBrak+5      �� 5      $��1��6$   $��Bottom=�61   $
��Left=�6L   �� 5      $�Кол-во: ��6"    �� 5      �6"   �� *Count+5      5       5!      5"      5$      .��5'      �  5(   
   �� 5)      $��40 �6   �� 5*      $��30 �6   �� 5+      �� 5,      $��30 �6   .+�5/   
   �� $��0��6   $-��'Отчет по рабочему дню��6   $��Center=�6=   $��Center=�6Z   $
��Bold"�6u   �� 50   
   $��1��6    �� Orientation$ 
Horizontal=�6"   .+�51      �� $ ��Всего деталей:��6   $��10(�6-   �� 52      -   5         ��Name$ numberDetailLabel��52      $��10(�6/   �� 53      -   5        $ 	DateLabel��53   4   $
��Bold"�6   $��10(�6&   $��33,0,0,0q�6G   $��80��6Y   54      �� 56   
   $��2��6   $��	15,0,0,15q�6$   .��57      �� -   5         ��Name$ orderItems2��57      #��[  58      59      �� 5;   
   -   5        $��3��5;      $
��Ок��68   $	��100��6E   $��30��6Q   $��Center=�6]   $��Bottom=�6z   5<      5=      