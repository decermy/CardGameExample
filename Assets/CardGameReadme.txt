StateController - ��������� ����� �������

�       RootStateManager
�       �       RootState
�       �       �       EnemyStateManager
�       �       �       �       �        ������ ���� ���������� [State]
�       �       �       �       �        �������� ���� ����������� ���� - ��������� [State]
�       �       �       �       �        ��������� ����������� �������� [State]
�       �       �       �       �        �������� ����� �������� [State]
�       �       �       �       �        ��������� ��� [State]
�       �       �       HeroStateManager
�       �       �       �       �        ������ ���� ������ [State]
�       �       �       �       �        �������� ��������� ������� [State]
�       �       �       �       �        �������� ���� ����������� ���� [State]
�       �       �       �       �        ��������� ������� � �(������� � �������) [State]
�       �       �       �       �        ������ ������ � ���� (������� � �������) [State]
�       �       �       �       �        ~����� ������ �����~ [State]
�       �       �       �       �        ��������� ���, ����� ������� = 0 ��� ����� ����� ������ ������ ���� [State]

RootStateManager - ����� ������, � ������ RootState ��� ����� ������
������ RootState ����� ������� ��������� ����������(�����\���������)

��� [State] ���������� ���������������� Action - ��������� �������, � ������� Do(Action DoTransitionCallback), � ������� ����������� ���������, ���� ����������� ���������, ����� ������ ������� DoTransitionCallback, ����� ���������� ������

������� ��������� � GameConfigManager, ���� 3 �������:
�      CardConfig -  ��������� ������
�        �        ������� ����� ����
�        �        ������ ����� (������� ����� ���� �������� ������ ���)
�        �        ������ ������ (�������� �������/������� ����)
�        �        ������ ����� (�������)

//��� "������ ������" - ������ �������� ����, � ������������
���������� ����� ����� ������:
SetFields() - ���������� ��������� ���� ����(����, ����) �� �����, � RealizeComponent() - ����� ����� ����������� 

�      EnemyConfig -  ��������� ������
�      �        ���
�      �        ���-�� ��
�      �        ������ ��������� ������������ � ����������

//��� ����������� ����� ���������� ������������, ��� ��������� ������:
SpellPreset() - ����� ����������� � AnnouncedAction() - ����� �����������

�      HeroConfig -  ��������� ������
�      �        ���-�� ��
�      �        ���-�� �������
_________________________
����, ����� - �������, ����� ���� ���������� (EnemyVisualModel, HeroVisualModel), � ����������� ����������� ���� � ������� ����� ���������� ���������� 
����, ����� - ������� ������������ � BattleManager
����� BattleManager ������ ������ � ��������� ������, ����������, ������ �� ���� � � ������

__________________________
InputController - ������ �������, ����� ����, ������ ������, ������ ���������, ������������� StateController � ������ ������\���������
��������� ������� ���� �� ����

