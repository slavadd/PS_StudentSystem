   M S B A M L   `   `   `  ����L  HStudentInfoSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StudentInfoSystemStudentInfoSystem  5   	   I)clr-namespace:StudentInfoSystem.ViewModelStudentInfoSystem.ViewModel  5   	   !    StudentInfoSystem.LoginForm   5   	   -	ViewModelclr-namespace:StudentInfoSystem  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:StudentInfoSystem.ViewModel     5   	     � Title$  	LoginForm��5	   	   $	��450��6   $	��800��6(    � DataContext 5
      ,  &StudentInfoSystem.ViewModel.TestAction  5   
    J� InputBindings 5      �� 5   
   
 �� Key$ Enter��6    �� Command 6!   �� *	getData+.��5      � .+�5   
   �� $��Вход��6   $��Stretch=�6"   $��10q�6@   $	��270��6L   $	��Top=�6Y   6s   �� 5   
   -   5         ��Name$ 
LabelLogin��5      $��Входни данни��6$   $y�Visible=�6;   $
��Left=�6Q   $	��Top=�6l   $��63��6�   $��
204,10,0,0q�6�   $	��264��6�   $��30(�6�   �� 5   
   -   5        $ 	LabelName��5      $��Парола:��6#   $y�Visible=�65   $
��Left=�6K   $	��Top=�6f   $��40��6~   $��110,163,0,0q�6�   $��95��6�   $��18(�6�   �� 5   
   -   5         ��Name$ 
txtBoxName��5      $y�Visible=�6d   $
��Left=�6y   $��20��6�   $��203.8,122,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��245��6�   $��1��6�   ��6&   �� *	St_name+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $ 	LabelPass��5      $��Име:��6#   $y�Visible=�62   $
��Left=�6H   $	��Top=�6c   $��40��6{   $��106,118,0,0q�6�   $��99��6�   $��18(�6�   �� 5   
   -   5        $ 
txtBoxPass��5      $y�Visible=�6d   $
��Left=�6y   $��20��6�   $��204,173,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��245��6�   ��6&   �� *	St_pass+$ PropertyChanged=�6�   �� 5    
   -   5        	 ��Name$	 enterButton��5       $��Enter��6&   $y�Visible=�6R   $
��Left=�6h   $��40��6�   $��266,237,0,0q�6�   $	��Top=�6�   $	��100��6�   ��66   �� *	getData+6�   5"      5#      