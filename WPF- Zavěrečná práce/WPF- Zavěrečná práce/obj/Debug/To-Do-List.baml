   M S B A M L   `   `   `  ����S  OWPF- Zavěrečná práce, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:WPF__Zavěrečná_práceWPF__Zavěrečná_práce  5   	   )    #WPF__Zavěrečná_práce.To_Do_List   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:WPF__Zavěrečná_práce     5   	     � Title$  
To_Do_List��5   	   $	��450��6   $	��800��6)   $	��450��5	   	   $	��800��6   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��0.35* �6   �� 5      $��0.16* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      $��0.55* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��	TasksList��5      
�������$��0��6=   $��5��6M   ��5   =   �� *
AllTasks+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5       �� ��6$   �� *Name+5!      5"      5&      �� 5'   
   $��Name:��6   $��0��6    $��1��6-   �� 5(   
   $��	Deadline:��6   $��1��6$   $��1��61   �� 5)   
   $��Description:��6   $��2��6'   $��1��64   �� 5+   
   -   5         ��Name$ ToDeleteLabel��5+   F   $��0��6)   $��2��66   ��6   �� *Name+6F   �� 5,   
   $��1��6-   $��2��6:   $��70��6J   $
��Left=�6U   ��6   �� *
Deadline+6U   �� 5-   
   $��1��6(   $��2��65   $
��70,0q�6E   $
��Left=�6S   ��6   �� *Day+6S   �� 5.   
   $��2��60   $��2��6@   $��3��6M   ��6   �� *Description+6M   �� 50   
   -   5         ��Name$
 Done��50      $
��Done��6   $��2��51      $��5��6!   $	��200��6.   $��66��6:   $��Right=�6F   
�������52      �� 54   
   -   5        $ 	AddButton��54      $��Add Task��6$   $��0��55      $��5��6!   $��0, 10q�6.   
�������6=   56      57      