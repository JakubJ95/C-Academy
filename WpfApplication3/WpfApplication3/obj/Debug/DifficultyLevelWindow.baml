   M S B A M L   `   `   `  ����J  FWpfApplication3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication3WpfApplication3  5   	   +    %WpfApplication3.DifficultyLevelWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication3     5   	     � WindowStartupLocation$  CenterScreen=�5   9    � Title$
 Memo��5   	   $	��390��6   $	��681��6#   .��5	      � .+�5
   
   �� $��142,22,142,10q�6   .+�5      �� 
����� �$��2q�6(   $��5,5,5,5q�6<   ._�5      �� .+�5      �� $��10q�6   $��20(�6(   $
��Bold"�66   $��30��6H   $
��Left=�6T   Wybierz poziom trudności6�   	� 5      -   5         	�Name$ latwy��5      $��Łatwy (10 par)��6)   $��5q�6B   	� 5      -   5        $ trudny��5      $��Trudny (20 par)��6*   $��5q�6D   5      5      �� 5      
����� �$��2q�6(   $��5,5,5,5q�6<   ._�5      �� .+�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� -   5         ��Name$ tekstPierwszegoGracza��5   $   $��15,0,0,0q�6C   $��17(�6U   $
��Bold"�6c   $��25��6u   $
��Left=�6�   �� 6�   $�Wpisz imie gracza I��6�   6�   �� 5      -   5        $ tekstDrugiegoGracza��5   $   $��20,0,0,0q�6A   $��17(�6S   $
��Bold"�6a   $��25��6s   $��Right=�6    J� RenderTransformOrigin$ 0.836,0.634&�6�   $	��163��6�   �� 6�   $�Wpisz imie gracza II��6�   6�   5      �� 5      $ 
Horizontal=�6!   $��0,0,10,0q�6:   $��54��6L   .+�5      �� -   5         ��Name$
 imie��5   "   $��23��60    �� TextWrapping$
 Wrap=�6=   $��10,0,0,0q�6Q   $	��169��6c   �� 5      -   5        $ imieDrugiegoGracza��5   "   $��23��6>   $
 Wrap=�6K   $��10,0,0,0q�6_   $	��169��6q   5      5      5      �� 5      -   5         ��Name$
 play��5      $
��Graj��6#   $	��349��62   $��10,0,0,0q�6>   $
��Left=�6c   �� 5      $ 
Horizontal=�6   $	��105��62   .+�5       �� -   5        $ warning��5       
���  ��$
��Bold"�6<   $
 Wrap=�6N   $��	18,19,0,0q�6b   	 �� 
IsReadOnly	 . $��0q�6�   $	��163��6�   �� 5!      -	   5        $ warningGraczaDrugiego��5!      
���  ��$
��Bold"�6K   $
 Wrap=�6]   $��	18,19,0,0q�6q   	 . $��0q�6�   $	��163��6�   5#      5%      5&      5'      