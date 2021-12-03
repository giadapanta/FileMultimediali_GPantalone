/*Creare una Console Application che permetta a un utente di gestire i suoi file multimediali.
I file multimediali possono essere canzoni o podcasts.
Le canzoni hanno:
- Titolo
- Autore
- Genere *

I podcasts hanno:
- Titolo
- Autore
- Descrizione
- un insieme di Episodi

Gli episodi hanno:
- Titolo
- Durata *
- Flag per sapere se è già stato ascoltato l’episodio. In fase di creazione l’episodio NON è ancora
stato ascoltato

L’autore ha:
- Nome
- Cognome
- Anno di nascita

Un utente può
- Visualizzare tutte le canzoni – stampare a video le proprietà;
- Visualizzare tutti i podcasts – stampare a video le proprietà esclusi gli episodi;
- Scelto un genere, visualizzare tutte le canzoni di quel genere
- Scelto un podcast, visualizzare tutti i suoi episodi
- Scelta una durata, visualizzare tutti gli episodi con durata minore o uguale alla durata inserita –
stampare le proprietà degli episodi e il titolo del podcast a cui appartiene l’episodio
- (facoltativo) Crearsi una playlist di canzoni
- (facoltativo) Scegliere quale episodio riprodurre e aggiornare il flag ad ascoltato.

Requisiti tecnici:
- Usare adeguatamente il concetto di classe e interfaccia
- Usare una nomenclatura conforme
- Usare la corretta gerarchia tra le classi e la corretta architettura
- E’ preferibile usare LINQ con Lambda
- Dove possibile usare i generics
- Attenzione alle proprietà con *
*/

/* 
 * RISPOSTE TEORIA:
 * 1a inizializzazione, 1b dichiarazione, 1c assegnazione
 * 2B, 3C, 4C, 
 * 5: 0 , null, stringa vuota, null 
 */
using FileMultimediali_GPantalone;

Menu.Start();