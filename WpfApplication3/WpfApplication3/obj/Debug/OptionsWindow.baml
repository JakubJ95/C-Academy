   M S B A M L   `   `   `  ����J  FWpfApplication3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication3WpfApplication3  5   	   #    WpfApplication3.OptionsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication3     5   	     � WindowStartupLocation$  CenterScreen=�5   1    � Title$
 Memo��5   	   $��370.502��6   $��681.695��6'   .��5	      � .+�5
   
   �� $��Center=�6   $��Center=�61   $	��355��6N   $��98,21,100,-21q�6[   $	��476��6r   .+�5      �� $��2q�6   
����� �$��5,12,5,0q�6<   ._�5      �� .+�5      �� -   5         ��Name$ label��5      $��OPCJE��6+   $��Center=�6;   $��Heavy"�6_   
����  �$��Times New Roman)�6�   $��30(�6�   $��Center=�6�   $��38��6�   $	��344��6�   $
��66,0q�6�   �� 5      -   5         ��Name$ checkBox��5      $��Efekty dźwiękowe��61   $��10,5,0,0q�6L    d� 	IsChecked$
 trueY�6^   �� 5       �� Orientation$ 
Horizontal=�6!   $��0,0,0,5q�6:   .+�5      �� -   5        $ labe2��5       $��
Kolor tła��6/   $��10,0,0,0q�6C   �� 5      -   5         ��Name$ comboBox��5   #   $��
10,0,223,0q�65    �� SelectedValuePath$ Content��6I   .@�5      ��  �� 
IsSelected . .��6=   Biały6D   �� 5      .��6+   	Niebieski66   �� 5      .��6+   	Zielony64   �� 5      .��6+   
Żółty62   �� 5      .��6+   
Różowy63   5      5      5      5      �� 5      $��2q�6   
����� �$��5,5,5,0q�6<   ._�5      �� .+�5      �� -   5        $ zasady��5      $��
ZASADY GRY��6,   $��Center=�6A   $��Heavy"�6e   
����  �$��Times New Roman)�6�   $��30(�6�   $��Center=�6�   $��41��6�   $	��344��6�   $
��66,0q�6�   �� 5      -   5        	 ��Name$	 
jedengracz��5       
 �� TextAlignment$
 Justify=�64   $��
10,10,10,0q�6L   $
��Wrap=�6`   B� 6u   .�6   Tryb jednoosobowy6�   �� - zadaniem gracza jest odkrycie wszystkich par planszy w jak najkrótszym czasie. Czas jest zatrzymywany po wybraniu dwóch przycisków. Po trzecim kliknięciu obrazki znikają a czas jest wznawiany.6a  �� 5      -   5        $	 dwochgraczy��5       $
 Justify=�65   $��
10,10,10,0q�6M   $
��Wrap=�6a   $��75��6u   B� 6�   .�6�   Tryb wieloosobowy6�   �� - Wszystkie reguły z trybu dla jednego gracza nadal obowiązują. Rozgrywkę wygrywa gracz posiadający na jej końcu większą liczbę par. Jeżeli liczba par obu graczy jest identyczna to wygrywa gracz, który ukończył rozgrywkę w krótszym czasie. Jeżeli czas również jest identyczny to następuje remis.6�  5       5!      �� 5"      -   5         ��Name$ button��5"      $��Zapisz i wróć do menu��6%   $��	10,5,10,0q�6E   $��Center=�6n   $	��456��6�   5#      5%      5&      