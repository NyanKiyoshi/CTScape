<div align='center'>
  <img src='./.gitlab/assets/screenshot.jpg' alt='Chargement du screenshot...' />
  <p><i>Projet T4 - Martin Monteil, William Guthmann, Mikail Kocak</i></p>
  <p><strong><big>Apprenez le vocabulaire des transports en commun strasbourgeois tout en jouant !</big></strong><br/>
     <i>Learn the French public transports vocabulary through playing!</i></p>
  <p>&nbsp; <!-- bottom margin --></p>
</div>

## Téléchargement et Installation
<div align='left'>
  Vous retrouverez la dernière version en téléchargement pour Windows (seulement)
  <a href='https://git.unistra.fr/wguthmann/scl19-t4-d/tags'>ici</a>.
</div>

<div align='right'>
  <a href='https://git.unistra.fr/wguthmann/scl19-t4-d/tags'>
    <img src='./.gitlab/assets/exe.png' alt='' width='140px' />
  </a>.
</div>

## Développement
### Prérequis
- Un système Windows 7 ou supérieur ;
- [.NET Framework 4.6.1](https://www.microsoft.com/en-us/download/details.aspx?id=49981) ;
- [Visual Studio 16.0 (2017) ou supérieur](https://visualstudio.microsoft.com/downloads/).

<div align='center'>
  <a href='#'>
    <img src='./.gitlab/assets/windows.png' alt='' width='70px' />
  </a>
  &nbsp;
  <a href='#'>
    <img src='./.gitlab/assets/.net.png' alt='' width='70px' />
  </a>
  &nbsp;
  <a href='https://visualstudio.microsoft.com/downloads/'>
    <img src='./.gitlab/assets/visual-studio.png' alt='' width='70px' />
  </a>
</div>

### Installation
1. Cloner `git@git.unistra.fr:wguthmann/scl19-t4-d.git` ;
1. Lancer la solution du projet [`CTScape/CTScape.sln`](CTScape/CTScape.sln).

### Releasing
<table style='border: 0'>
<tbody>
<tr style='border: 0'>
<td style='border: 0' width='83%'>
  <ol>
    <li><a href='http://www.jrsoftware.org/isdl.php#stable'>Installer Inno Setup</a> ;</li>
    <li>Compiler <a href='./installer.iss'>installer.iss</a> avec Inno Setup ;</li>
    <li><ol>
      <li>Double clique sur <a href='./installer.iss'>installer.iss</a> ;</li>
      <li>Mettre à jour la version du programme : <code>#define AppVersion ...</code> ;</li>
      <li>Build > Compile.</li>
    </ol></li>
    <li><a href='https://git.unistra.fr/wguthmann/scl19-t4-d/tags'>Ajouter un nouveau tag</a> ;</li>
    <li>Glisser le <code>.exe</code> généré par Inno Setup ;</li>
    <li>Mettre <a href='.gitlab/RELEASE_TEMPLATE.html'>ce code</a> en description.</li>
  </ol>
</td>
<td width='20%'>
  <img src='.gitlab/assets/startup.png' alt='Ship it!' />
</td>
</tr>
</tbody>
</table>

