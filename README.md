# Gameweb-App

Gameweb by Maciej Chlebny

Prosta aplikacja korzystająca z bazy danych, symulująca portal typu filmweb.

Aplikacja umożliwia:
1. Wyświetlanie tabel z bazy danych
2. Usuwanie rekordów z bazy
3. Modyfikowanie danego rekordu
4. Dodawanie nowych rekordów
5. Generowanie prostego raportu
6. Zmianę połączenia do innej instancji bazy

Aplikacja została napisana w języku C# z użyciem technologii Windows Forms .Net Framework 4.7.2 w Visual Studio 2019
i łączy się z instacją bazy danych z MS SQL Server.

Tworzenie bazy danych
* Proszę o stworzenie serwera MQ SQL Server conajmniej wersji 2016
  gdyż używam klauzuli DROP DATABASE IF EXISTS
* Następnie proszę o uruchomienie skryptów w kolejności *-create.sql i *-fill.sql
* Potem należy skonfigurować serwer by można się z nim połączyć tak jak na zajęciach

Krótkie omówienie aplikacji
* Połączenie do bazy danych

  Domyślnie aplikacja łączy się z bazą danych postawioną na serwerze prowdzonym przez mojego znajomego.
  Aby połączyć się z inną instancją należy w menu konfiguracji podać connection string w poprawnej
  formie (jak zrobić connection string https://www.connectionstrings.com/sql-server/ ).
  Niestety nie aplikacja nie waliduję poprawnośći connetion stringa  
  
* Modyfikacja

  Aby zmodyfikować dany rekord z danej tabeli, należy wyświetlić tabelę przy pomocy Tables
  a następnie zaznczyć daną wartość w pierwszej kolumnie i kliknąć przycisk Insert,
  wówczas wyświetli się formularz modyfikacji danych
  
  W nazwach cudzysłowy i apostrofy nie są dopuszczalne.

  
* Usuwanie

  Aby usunąć dany rekord z danej tabeli, należy wyświetlić tabelę przy pomocy Tables
  a następnie zaznczyć daną wartość w pierwszej kolumnie i kliknąć przycisk Delete.
  
  Usuwanie z zazczeniem w drugiej kolumnie usuwa ocenę danego gracza lub ocenę danej gry,
  w zależności która tabela jest wyświetlana w pierwszej kolumnie.
  
  Usuwanie z zaznaczeniem w Addition data pozwala na usuwanie tylko gatunku danej gry z kolumny pierwszej.

* Dodawanie

  Aby dodać rekord należy kliknąć w pasku na Add Element i wybrać który element chcemy dodać.
  Wyświetli się wówczas formularz pozwalający nam na dodanie nowego rekordu.
  
  W nazwach cudzysłowy i apostrofy nie są dopuszczalne.
  
  Dany użytkownik może ocenić tylko gry których jeszcze nie ocenił,
  jeśli chcemy zmienić ocenę należy usunąć obecną ocenę i dodać nową

"It's not a bug, it's a feature" czyli znalezione błędy do naprawy:
- odświeżenie zawartości bazy po jakiejkolwiek modyfikacji
- brak zapisywania customowego string connection do pliku, trzeba podawać za każdym uruchomieniem aplikacji string
- wolne działanie poprzez operacje na stringach
- modyfikacja User pozwala tylko na zmianę kraju
- modyfikacja Game nie ustawia domyślnej wartości kraju na obecny kraj gry
- modyfikacja Game nie pozwala na usunięcie grze gatunku, trzeba usuwać zewnętrznie
- modyfikacja Country pozwala tylko na zmianę nazwy
- kiepskie formatowanie raportu, lepsze wyrównanie
- brak wyświetlanie kraju pochodzenia gry
- dany użytkownik może ocenić tylko gry których jeszcze nie ocenił
- brak walidacji poprawności connection stringa
- brak walidacji nazw pod względem cudzysłowiów
- ogólnie problemy z walidacją
