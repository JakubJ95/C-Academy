   M S B A M L   `   `   `  ����J  FWpfApplication3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication3WpfApplication3  5   	       WpfApplication3.Memo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication3     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   (    � Title$
 Memo��5   	   $��430.05��6   $��681.695��6&   .��5	      � -   5        $��Frame��5	      .+�5
   
   �� -   5         ��Name$
 Czas��5
      $��Heavy"�6    $
��Left=�63   $��23��6N    �� TextWrapping$
 Wrap=�6Z   $	��Top=�6o   $��90��6�   $��	42,66,0,0q�6�   {�.  6�   �� 5   
   -   5        $ Ruchy��5      $��Heavy"�6!   $
��Left=�64   $��23��6O   $
 Wrap=�6[   $	��Top=�6o   $	��114��6�   $��
137,66,0,0q�6�   {�.  6�   � 5   
   -   5        $��	Przyciski��5      $
��Left=�6    $	��244��6;   $	��Top=�6H   $	��582��6`   $��
42,115,0,0q�6l    � ColumnDefinitions 5      �� 5      $��58 �6#   �� 5      $	��58* �6#   �� 5      $	��58* �6#   �� 5      $	��58* �6#   �� 5      $	��58* �6#   �� 5      $	��58* �6#   �� 5      $��58 �6#   �� 5      $	��59* �6#   �� 5      $	��58* �6#   �� 5      $��59 �6#    � RowDefinitions 5      �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    5      �� 5    
   -   5         ��Name$ 	CzasLabel��5       $
��Czas��6$   $
��Left=�63   $	��Top=�6N   $��	42,35,0,0q�6f   �� 5!   
   -   5        $ 
RuchyLabel��5!      $��
Liczba par��6$   $	��Top=�69   $��
137,35,0,0q�6Q   �� 5"   
   -   5        $ CzasDrugiegoGracza��5"      $��Heavy"�6.   $��Right=�6A   $��23��6]   $��00:00:00��6i   $
 Wrap=�6y   $	��Top=�6�   $��90��6�   $��
0,66,241,0q�6�   {�.  6�   �� 5#   
   -	   5        $ RuchyDrugiegoGracza��5#      $��Heavy"�6/   $��Right=�6B   $��0��6^   $��23��6h   $
 Wrap=�6t   $	��Top=�6�   $	��114��6�   $��
0,66,111,0q�6�   {�.  6�   �� 5$   
   -
   5        $ CzasLabelDrugiegoGracza��5$      $
��Czas��61   $��Right=�6@   $	��Top=�6\   $��
0,35,297,0q�6t   �� 5%   
   -   5        $ RuchyLabelDrugiegoGracza��5%      $��
Liczba par��62   $��Right=�6G   $	��Top=�6c   $��
0,35,162,0q�6{   �� 5&   
   -   5        $ ImiePierwszegoGracza��5&      $
��Bold"�6.   $��Courier New)�6@   $��15(�6Z   
���  ��$
��Left=�6y   $��	42,10,0,0q�6�   $	��Top=�6�   $��30��6�   $	��220��6�   6�   �� 5'   
   -   5        $ ImieDrugiegoGracza��5'      $��Courier New)�6,   $
��Bold"�6E   $��15(�6W   
���  ��$
��Left=�6v   $��
330,10,0,0q�6�   $	��Top=�6�   $��30��6�   $	��220��6�   5*      5+      