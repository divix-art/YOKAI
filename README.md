# Yokai3D Unity project


### Aggiungere una chiave SSH Key [facoltativo]
Usare una chiave SSH serve per rendere più sicuri ed immediati gli interventi sul progetto.
Seguire le indicazioni in questo link
https://www.inmotionhosting.com/support/server/ssh/how-to-add-ssh-keys-to-your-github-account/

---

### Installare GIT per versionare le modifiche
Usare solo gitbash ( [windows] click destro -> gitbash / [mac] terminale) e non gitGUI. GitGUI [immagine](https://git-scm.com/book/en/v2/images/gitk.png) è l'app di git con intefaccia grafica user friendly, purtroppo non con tutte le versioni funziona correttamente e crea problemi per cui, per precauzione, non lo useremo.

Per verificare se git è già installato, aprire un terminale e scrivere:
```
git –version
```

Se git non è installato, [questo è il link per scaricarlo](https://git-scm.com/downloads)

---

### Clonare il progetto YOKAI sul proprio computer
Per poter lavorare al progetto occorre "clonare" la cartella del progetto sul proprio computer:

- Dalla schermata della repo su [Github](https://github.com/divix-art/YOKAI), in alto a destra, premere il pulsante verde [<> Code] e copiare il [repo_link]; se hai già installato la SSH Key premi su SSH e copia il link corretto.

- In un terminale git scrivere:       
```
git clone [repo_link]
```

- Premere invio e attendere il download, se usi SSH Key dovrai inserire la passphrase

---

### Staccare un branch
Per permetterci di lavorare in parallelo sul progetto e per essere sicur di versionare correttamente tutte le modifiche, prima di iniziare a modificare il progetto devi creare un nuovo branch isolato su cui lavorare:

- In un terminale git scrivere:
```
git checkout -b [area_intervento]/[descrizione_modifiche]
```

*es.     assets/add_sprites      code/physic_bugfix      scenes/mainmenu_scene*

---

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

*La prima volta che si pusha un nuovo branch viene visualizzato un errore sul terminale git, questo errore suggerisce di eseguire il push con alcuni parametri extra (git push --set-upstream origin [nome-branch]), copiare il comando suggerito ed eseguirlo nel terminale per effettuare correttamente il push*

- Verificare sulla repo del progeto su [Github](https://github.com/divix-art/YOKAI) che il branch sia arrivato correttamente

---

### Richiedere una MERGE REQUEST (unire le modifiche fatte nel branch main)
Quando si lavora in parallelo sullo stesso progetto, capita spesso che più persone intervengano sullo stesso file, ciò può creare conflitti in fase di push dei branch.

Per evitare di perdere parte delle modifiche introdotte **non pushare mai il branch MAIN**, ossia il branch principale di lavoro.

Per rendere effettive le modifiche pushate nel proprio branch, è necessario creare una Merge Request:

1) dopo aver pushato il proprio branch, andare sulla repo del progeto su [Github](https://github.com/divix-art/YOKAI)

2) se il push è stato effettuato da poco, nella parte alta della schermata esce un box giallo con il nome del branch, la scritta "had recent pushes ..." ed un pulsante verde sulla destra con scritto [Compare & pull request]; premere il pulsante [Compare & pull request]

2a) se il pulsante [Compare & pull request] non fosse visibile, premere sul pulsante che indica il numero di branches del progetto *es. 2 branches*

2b) cercare il proprio branch, premere sui tre pallini sulla destra e selezionare la voce "New pull request"

3) Nella schermata che appare, sulla destra, selezionare la voce Assignees e scegliere "Milosauro" per assegnare il compito di verificare la Pull Request (richiesta di unione delle modifiche)

4) Premere il pulsante verde "Create pull request" in basso a destra

5) Nella schermata che appare, nella zona centrale, verificare se viene visualizzata la scritta **This branch has no conflicts with the base branch** in verde oppure **This branch has conflicts that must be resolved** in grigio

5a) Avvisare su discord Milosauro per analizzare e mergiare le modifiche, specificando se la scritta verificata in precedenza sia quella verde (no conflicts) o quella grigia (has conflicts)

6) Per verificare che la "Pull request" sia stata creata, nella parte alta della repo del progeto su [Github](https://github.com/divix-art/YOKAI) premere il pulsante "Pull requests" e verificare che la propria richiesta sia in elenco