# Yokai3D Unity project


### Aggiungere una chiave SSH Key [facoltativo]
Usare una chiave SSH serve per rendere più sicuri ed immediati gli interventi sul progetto.
Seguire le indicazioni in questo link
https://www.inmotionhosting.com/support/server/ssh/how-to-add-ssh-keys-to-your-github-account/



### Installare GIT per versionare le modifiche
Usare solo gitbash ( [windows ]click destro -> gitbash / [mac] terminale) e non gitGUI. Per verificare se git è già installato, aprire un terminale e scrivere:
```
git –version
```

Se git non è installato, [questo è il link per scaricarlo](https://git-scm.com/downloads)



### Clonare il progetto YOKAI sul proprio computer
Per poter lavorare al progetto occorre "clonare" la cartella del progetto sul proprio computer:

- Dalla schermata della repo su [Github](https://github.com/divix-art/YOKAI), in alto a destra, premere il pulsante verde [<> Code] e copiare il [repo_link], se hai già installato la SSH Key premi su SSH e copia il link corretto

- In un terminale git scrivere:       
```
git clone [repo_link]
```

- Premere invio e attendere il download, se usi SSH Key dovrai inserire la passphrase



### Staccare un branch
Per permetterci di lavorare in parallelo sul progetto e per essere sicur di versionare correttamente tutte le modifiche, prima di iniziare a modificare il progetto devi creare un nuovo branch isolato su cui lavorare:

- In un terminale git scrivere:
```
git checkout -b [area_intervento]/[descrizione_modifiche]
```

*es.     assets/add_sprites      code/physic_bugfix      scenes/mainmenu_scene*



### Pushare le modifiche
Dopo aver concluso una fase di modifiche ed essere arrivati ad un risultato stabile, occorre pushare le modifiche online, per non perdere il lavoro fatto.
**Per una più facile gestione delle modifiche, pushare spesso il lavoro fatto**

Per effettuare il push accedere ad un terminale git ed eseguire i seguenti passi:

- **Verificare che non si stia pushando in main!!!**

- verificare le modifiche effettuate:
```
git status
```

- aggiungere alcuni file (vedi elenco da status) modificati oppure tutti con il comandp add:
```
git add .
```
```
git add [files]
```

- committare le modifiche effettuate, inserendo una [gitmoji](https://gitmoji.dev/) relativa al tipo di intervento eseguito e inserendo un commento che spieghi in breve le novità introdotte:

```
git commit -m [commento]
```

*es.     git commit -m ":bug: MainMenu scene: fix option button bug"     git commit -m ":bento: Assets: add tanuki sprites"*

- pushare le modifiche sulla repo online
```
git push
```

*La prima volta che si pusha un nuovo branch viene visualizzato un errore sul terminale git, questo errore suggerisce di eseguire il push con alcuni parametri extra (upstream), copiare il comando suggerito ed eseguirlo nel terminale per effettuare correttamente il push*

- Verificare sulla repo del progeto su [Github](https://github.com/divix-art/YOKAI) che il branch sia arrivato correttamente



### Richiedere una MERGE REQUEST (unire le modifiche fatte nel mail)
Quando si lavora in parallelo sullo stesso progetto, capita spesso che più persone intervengano sullo stesso file, ciò può creare conflitti in fase di push dei branch.

Per evitare di perdere parte delle modifiche introdotte **non pushare mai il branch MAIN**.

Per rendere effettive le modifiche pushate nel proprio branch, è necessario creare una Merge Request,