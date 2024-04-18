# Rendszerfejlesztés Beadandó 1-es csapat Car-Rental

<h2>Szoftverek</h2>
  <h3>Adatbázis</h3>
       <p> MYSQL szerver használat: Telepítse a MYSQL szervert és a MYSQL WorkBenchet ----> Hozzon létre egy Localhost szervert a  default :3306-os porton az adatbázis jelszava legyen [admin123]/ Vagy a backend-ben az app propertiesben szerkessze a szerver tulajdonságait </p>
        <p> Hozzon létre az adatbázisban egy car_rental_db Schemat az alkalmazás legenerálja az adatbázist futtatáskor 
          <h3>//VAGY//</h3> Ha az előre elkészített  adatbázist akarja használni  akkor a MQSQL Workbench alkalmazásban ha belépett a szerverre a Server menüponton belül a Data Importra kattintva importálja be az SQL mappában található SQL fájlt  ---> Itt vannak felvitt autók és foglalások is </p>
  
  <h3>
    Backend
  </h3>
  <p>
    A Backendet Futtassa IntelliJ IDEA projektként vagy Visual Studio Code Projektként vagy pedig terminálon ( Tesztelve IntelliJ IDEA projekt futtatással volt)
    Terminálban való futtatás esetén: Terminál nyitás backend mappában majd mvn package(ha nincs pl. brew install mvn(mac)) utána java -jar target/rent-a-car-spring-0.0.1-SNAPSHOT.jar parancs
  </p>
<h3>FrontEnd</h3>
<p>Nyissa meg a projekt mappáját Visual Studio Code-ban vagy Terminálban majd Adja ki  <h3>ng serve(ha kell npm install előtte)</h3> parancsot az Angular projekt Buildeléséhez</p>
<h3>Használat</h3>
<p>Webhely: http://localhost:4200/login </p>
<p>Admin bejelentkezés</p>
<h3>Admin@test.com|admin</h3>
<p>Felhasználó bejelentkezés</p>
<h3>balint@test.com|balint || Vagy regisztráljon új felhasználót</h3>

# Elkészült / hátralévő funkciók
### Funkciók
- [x] Bejelentkezés
- [x] Regisztráció
- [x] Autó felvétel
- [x] Autóbérlés elfogadása vagy elutasítása
- [x] Autók listázása
- [x] Szűrés kategóriák szerint
- [x] Autók kölcsönzése
- [x] Kölcsönzések megtekintése

### Mérföldkövek
- [x] Szerver - kliens kommunikáció
- [x] Adatbázis kapcsolat
- [x] Authentikáció - Authorizáció
 ### Tesztelve: Windows , MacOS

