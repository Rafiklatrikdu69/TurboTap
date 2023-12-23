import { NgModule } from '@angular/core';
import { CUSTOM_ELEMENTS_SCHEMA} from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserComponent } from './components/user/user.component';
import { HttpClientModule } from '@angular/common/http';
import { NgFor } from '@angular/common';
import { FormConnexionComponent } from './components/form-connexion/form-connexion.component';
import { HomeComponent } from './components/home/home.component';

import { InscriptionFormComponent } from './components/inscription-form/inscription-form.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { JeuComponent } from './components/jeu/jeu.component';
import { AffichageScoreComponent } from './components/affichage-score/affichage-score.component';
import { AffichageScorePartieComponent } from './components/affichage-score-partie/affichage-score-partie.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { MatPaginatorModule } from '@angular/material/paginator';
@NgModule({
  declarations: [
    
    AppComponent,
    UserComponent,
    FormConnexionComponent,
    HomeComponent,
    InscriptionFormComponent,
    JeuComponent,
    AffichageScoreComponent,
    AffichageScorePartieComponent
  ],
  imports: [
    MatPaginatorModule,
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserModule,
    MatSlideToggleModule,
    ReactiveFormsModule,
    FormsModule,
    BrowserAnimationsModule
  ],
  schemas:[CUSTOM_ELEMENTS_SCHEMA],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
