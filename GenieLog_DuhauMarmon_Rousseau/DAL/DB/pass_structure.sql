create database if not exists pass character set utf8 collate utf8_unicode_ci;
use pass;

grant all privileges on pass.* to 'pass_user'@'localhost' identified by 'secret';

drop table if exists appartenance;
drop table if exists compte;
drop table if exists categorie;
drop table if exists utilisateur;

create table utilisateur (
    util_id integer not null primary key auto_increment,
    util_identifiant varchar(100) not null unique,
    util_mdp varchar(100) not null,
	util_question integer not null,
	util_reponse varchar(250) not null
);

create table categorie (
    cate_id integer not null primary key auto_increment,
    cate_nom varchar(100) not null
);

create table appartenance (
	appartenance_id integer not null primary key auto_increment,
    util_id integer not null,
	cate_id integer not null,
	foreign key (cate_id) references categorie(cate_id),
	foreign key (util_id) references utilisateur(util_id)

);

create table compte (
  compte_id integer not null primary key auto_increment,
  compte_titre varchar(100) not null,
  compte_mdp varchar(100) not null,
  compte_identifiant varchar(100),
  compte_force integer not null,
  compte_date date not null,
  compte_site varchar(100),
  cate_id integer,
  util_id integer not null,
  foreign key (cate_id) references categorie(cate_id),
  foreign key (util_id) references utilisateur(util_id)
);