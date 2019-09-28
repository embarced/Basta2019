# !Basta2019 (Mainz)
Samples der Session “Evolutionäre Architekturen und Fitness Functions” der Basta Konferenz 2019 (Mainz)

- **Basta2019_Scientist:** Sample für A/B Testing auf Code-Ebene mit GitHub Scientist Framework (.NET Portierung davon)
- **Basta2019_Weather:** Sample für (Mini-) Chaos Engineering zwischen 2 Services mit Polly + Simmy als

## Download der Folien
Die Folien inkl. Archtitektur-Überblick findet hier hier: xxx

## Eingesetzte Frameworks
### Scientist.net
https://github.com/scientistproject/Scientist.net 

**Nuget Package:** https://www.nuget.org/packages/scientist/

### Polly
https://github.com/App-vNext/Polly 

**Nuget Package:** https://www.nuget.org/packages/Polly/

### Simmy
https://github.com/Polly-Contrib/Simmy 

**Nuget Package:** https://www.nuget.org/packages/Polly.Contrib.Simmy

### Polly & Simmy Project Page
http://www.thepollyproject.org

## Basta2019_Weather
### Weather API
https://openweathermap.org

Die verwendete Weather API stammt von OpenWeatherMap.

Für den Zugriff wird dort ein (gratis) Account benötigt. Sobald mal einen account eingerichtet hat, bekommt man einen ApiKey. Dieser wird in den beiden Controllern benötigt, um über den OpenWeatherMap Client auf die API zuzugreifen!
