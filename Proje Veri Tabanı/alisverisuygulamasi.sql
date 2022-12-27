--
-- PostgreSQL database dump
--

-- Dumped from database version 15.1
-- Dumped by pg_dump version 15.1

-- Started on 2022-12-27 22:27:06

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 6 (class 2615 OID 16660)
-- Name: kisi; Type: SCHEMA; Schema: -; Owner: postgres
--

CREATE SCHEMA kisi;


ALTER SCHEMA kisi OWNER TO postgres;

--
-- TOC entry 258 (class 1255 OID 16950)
-- Name: kisiekle(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.kisiekle() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
update public.sayi set sayitoplam=sayitoplam+1 from kisi.kisi where public.sayi.sayino=1;
return new;
end;
$$;


ALTER FUNCTION public.kisiekle() OWNER TO postgres;

--
-- TOC entry 255 (class 1255 OID 16941)
-- Name: kisigetiradsoyad(character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.kisigetiradsoyad(prmt character varying, prmt2 character varying) RETURNS TABLE(kisinoo integer, kisiadd character varying, kisisoyadd character varying, kisitell character varying, kisitipp character varying)
    LANGUAGE plpgsql
    AS $$
begin
return query
select
kisino,
kisiad,
kisisoyad,
kisitel,
kisitip
from kisi.kisi
where 
kisiad like prmt and
kisisoyad like prmt2;
end;
$$;


ALTER FUNCTION public.kisigetiradsoyad(prmt character varying, prmt2 character varying) OWNER TO postgres;

--
-- TOC entry 256 (class 1255 OID 16942)
-- Name: kisigetirno(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.kisigetirno(prmt integer) RETURNS TABLE(kisinoo integer, kisiadd character varying, kisisoyadd character varying, kisitell character varying, kisitipp character varying)
    LANGUAGE plpgsql
    AS $$
begin
return query
select
kisino,
kisiad,
kisisoyad,
kisitel,
kisitip
from kisi.kisi
where 
kisino = prmt;
end;
$$;


ALTER FUNCTION public.kisigetirno(prmt integer) OWNER TO postgres;

--
-- TOC entry 259 (class 1255 OID 16952)
-- Name: kisisil(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.kisisil() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
update public.sayi set sayitoplam=sayitoplam-1 from kisi.kisi where public.sayi.sayino=1;
return new;
end;
$$;


ALTER FUNCTION public.kisisil() OWNER TO postgres;

--
-- TOC entry 254 (class 1255 OID 16940)
-- Name: musterigetirno(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.musterigetirno(prmt integer) RETURNS TABLE(musterinoo integer, emaill character varying, kisiadd character varying, kisisoyadd character varying, kisitell character varying)
    LANGUAGE plpgsql
    AS $$
begin
return query
select
kisino,
email,
kisiad,
kisisoyad,
kisitel
from musterilistesi
where 
kisino = prmt;
end;
$$;


ALTER FUNCTION public.musterigetirno(prmt integer) OWNER TO postgres;

--
-- TOC entry 241 (class 1255 OID 16958)
-- Name: siparisekle(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.siparisekle() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
update public.sayi set sayitoplam=sayitoplam+1 from public.siparis where public.sayi.sayino=2;
return new;
end;
$$;


ALTER FUNCTION public.siparisekle() OWNER TO postgres;

--
-- TOC entry 257 (class 1255 OID 16944)
-- Name: siparisgetirno(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.siparisgetirno(prmt integer) RETURNS TABLE(siparisnoo integer, musterinoo integer, kisiadd character varying, kisisoyadd character varying, kisitell character varying, musteritemno integer, teslimatnoo integer, kuryenoo integer, urunnoo integer, urunadd character varying, urunfiyatt integer)
    LANGUAGE plpgsql
    AS $$
begin
return query
select
siparisno,
musterino,
kisiad,
kisisoyad,
kisitel,
musteritemsilcino,
teslimatno,
kuryeno,
urunno,
urunad,
urunfiyat
from siparislistesi
where 
siparisno = prmt;
end;
$$;


ALTER FUNCTION public.siparisgetirno(prmt integer) OWNER TO postgres;

--
-- TOC entry 242 (class 1255 OID 16960)
-- Name: siparissil(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.siparissil() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
update public.sayi set sayitoplam=sayitoplam-1 from public.siparis where public.sayi.sayino=2;
return new;
end;
$$;


ALTER FUNCTION public.siparissil() OWNER TO postgres;

--
-- TOC entry 239 (class 1255 OID 16954)
-- Name: urunekle(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.urunekle() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
update public.sayi set sayitoplam=sayitoplam+1 from public.urun where public.sayi.sayino=3;
return new;
end;
$$;


ALTER FUNCTION public.urunekle() OWNER TO postgres;

--
-- TOC entry 240 (class 1255 OID 16956)
-- Name: urunsil(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.urunsil() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
update public.sayi set sayitoplam=sayitoplam-1 from public.urun where public.sayi.sayino=3;
return new;
end;
$$;


ALTER FUNCTION public.urunsil() OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 218 (class 1259 OID 16681)
-- Name: kargofirma; Type: TABLE; Schema: kisi; Owner: postgres
--

CREATE TABLE kisi.kargofirma (
    kisino integer NOT NULL,
    kfirmaad character varying(40) NOT NULL
);


ALTER TABLE kisi.kargofirma OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 16666)
-- Name: kisi; Type: TABLE; Schema: kisi; Owner: postgres
--

CREATE TABLE kisi.kisi (
    kisino integer NOT NULL,
    kisiad character varying(40) NOT NULL,
    kisisoyad character varying(40) NOT NULL,
    kisitel character varying(10) NOT NULL,
    kisitip character varying(20) NOT NULL
);


ALTER TABLE kisi.kisi OWNER TO postgres;

--
-- TOC entry 216 (class 1259 OID 16671)
-- Name: musteri; Type: TABLE; Schema: kisi; Owner: postgres
--

CREATE TABLE kisi.musteri (
    kisino integer NOT NULL,
    email character varying(40) NOT NULL
);


ALTER TABLE kisi.musteri OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 16676)
-- Name: musteritemsilci; Type: TABLE; Schema: kisi; Owner: postgres
--

CREATE TABLE kisi.musteritemsilci (
    kisino integer NOT NULL
);


ALTER TABLE kisi.musteritemsilci OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 16686)
-- Name: tedarikfirma; Type: TABLE; Schema: kisi; Owner: postgres
--

CREATE TABLE kisi.tedarikfirma (
    kisino integer NOT NULL,
    tfirmaad character varying(40) NOT NULL
);


ALTER TABLE kisi.tedarikfirma OWNER TO postgres;

--
-- TOC entry 229 (class 1259 OID 16857)
-- Name: fatura; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.fatura (
    faturano integer NOT NULL,
    tutar double precision NOT NULL,
    tarih character varying(20) NOT NULL,
    siparisno integer NOT NULL
);


ALTER TABLE public.fatura OWNER TO postgres;

--
-- TOC entry 222 (class 1259 OID 16721)
-- Name: il; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.il (
    il_plakano integer NOT NULL,
    ilad character varying(20) NOT NULL
);


ALTER TABLE public.il OWNER TO postgres;

--
-- TOC entry 228 (class 1259 OID 16796)
-- Name: ilce; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.ilce (
    ilceno integer NOT NULL,
    ilcead character varying(20) NOT NULL,
    acikadres character varying(100) NOT NULL,
    ilno integer NOT NULL
);


ALTER TABLE public.ilce OWNER TO postgres;

--
-- TOC entry 236 (class 1259 OID 16906)
-- Name: ilcelistesi; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.ilcelistesi AS
 SELECT ilce.ilceno,
    ilce.ilcead,
    ilce.acikadres,
    ilce.ilno,
    il.ilad
   FROM (public.ilce
     JOIN public.il ON ((ilce.ilno = il.il_plakano)));


ALTER TABLE public.ilcelistesi OWNER TO postgres;

--
-- TOC entry 226 (class 1259 OID 16751)
-- Name: kategori; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kategori (
    kategorino integer NOT NULL,
    kategoriad character varying(20) NOT NULL
);


ALTER TABLE public.kategori OWNER TO postgres;

--
-- TOC entry 223 (class 1259 OID 16736)
-- Name: kurye; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kurye (
    kuryeno integer NOT NULL,
    kfirmano integer NOT NULL,
    arac character varying(20) NOT NULL
);


ALTER TABLE public.kurye OWNER TO postgres;

--
-- TOC entry 237 (class 1259 OID 16915)
-- Name: kuryekargokontrol; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.kuryekargokontrol AS
 SELECT kurye.kuryeno,
    kurye.kfirmano,
    kargofirma.kfirmaad,
    kurye.arac
   FROM (public.kurye
     JOIN kisi.kargofirma ON ((kurye.kfirmano = kargofirma.kisino)));


ALTER TABLE public.kuryekargokontrol OWNER TO postgres;

--
-- TOC entry 220 (class 1259 OID 16711)
-- Name: siparis; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.siparis (
    siparisno integer NOT NULL,
    musterino integer NOT NULL,
    musteritemsilcino integer NOT NULL,
    teslimatno integer NOT NULL,
    kuryeno integer NOT NULL,
    urunno integer NOT NULL
);


ALTER TABLE public.siparis OWNER TO postgres;

--
-- TOC entry 232 (class 1259 OID 16883)
-- Name: kuryekontrol; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.kuryekontrol AS
 SELECT kurye.kuryeno,
    siparis.siparisno,
    kurye.kfirmano,
    kargofirma.kfirmaad,
    kurye.arac
   FROM ((public.kurye
     JOIN kisi.kargofirma ON ((kurye.kfirmano = kargofirma.kisino)))
     JOIN public.siparis ON ((kurye.kuryeno = siparis.kuryeno)));


ALTER TABLE public.kuryekontrol OWNER TO postgres;

--
-- TOC entry 224 (class 1259 OID 16741)
-- Name: magaza; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.magaza (
    magazano integer NOT NULL,
    magazaad character varying(30) NOT NULL,
    magazaadres character varying(100) NOT NULL,
    magazatel character varying(10) NOT NULL,
    tfirmano integer NOT NULL
);


ALTER TABLE public.magaza OWNER TO postgres;

--
-- TOC entry 227 (class 1259 OID 16756)
-- Name: marka; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.marka (
    markano integer NOT NULL,
    markaad character varying(20) NOT NULL
);


ALTER TABLE public.marka OWNER TO postgres;

--
-- TOC entry 230 (class 1259 OID 16871)
-- Name: musterilistesi; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.musterilistesi AS
 SELECT musteri.kisino,
    musteri.email,
    kisi.kisiad,
    kisi.kisisoyad,
    kisi.kisitel
   FROM (kisi.musteri
     JOIN kisi.kisi ON ((musteri.kisino = kisi.kisino)));


ALTER TABLE public.musterilistesi OWNER TO postgres;

--
-- TOC entry 235 (class 1259 OID 16902)
-- Name: musteritemsilcilistesi; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.musteritemsilcilistesi AS
 SELECT musteritemsilci.kisino,
    kisi.kisiad,
    kisi.kisisoyad,
    kisi.kisitel
   FROM (kisi.musteritemsilci
     JOIN kisi.kisi ON ((musteritemsilci.kisino = kisi.kisino)));


ALTER TABLE public.musteritemsilcilistesi OWNER TO postgres;

--
-- TOC entry 238 (class 1259 OID 16945)
-- Name: sayi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.sayi (
    sayino integer NOT NULL,
    sayiad character varying(20) NOT NULL,
    sayitoplam integer NOT NULL
);


ALTER TABLE public.sayi OWNER TO postgres;

--
-- TOC entry 225 (class 1259 OID 16746)
-- Name: urun; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.urun (
    urunno integer NOT NULL,
    magazano integer NOT NULL,
    urunad character varying(30) NOT NULL,
    urunfiyat integer NOT NULL,
    urunstok integer NOT NULL,
    kategorino integer NOT NULL,
    markano integer NOT NULL
);


ALTER TABLE public.urun OWNER TO postgres;

--
-- TOC entry 233 (class 1259 OID 16892)
-- Name: siparislistesi; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.siparislistesi AS
 SELECT siparis.siparisno,
    siparis.musterino,
    kisi.kisiad,
    kisi.kisisoyad,
    kisi.kisitel,
    siparis.musteritemsilcino,
    siparis.teslimatno,
    siparis.kuryeno,
    urun.urunno,
    urun.urunad,
    urun.urunfiyat
   FROM ((public.siparis
     JOIN kisi.kisi ON ((siparis.musterino = kisi.kisino)))
     JOIN public.urun ON ((siparis.urunno = urun.urunno)));


ALTER TABLE public.siparislistesi OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 16716)
-- Name: teslimatadres; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.teslimatadres (
    teslimatno integer NOT NULL,
    ilno integer NOT NULL
);


ALTER TABLE public.teslimatadres OWNER TO postgres;

--
-- TOC entry 231 (class 1259 OID 16879)
-- Name: teslimatnoktasi; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.teslimatnoktasi AS
 SELECT teslimatadres.teslimatno,
    il.il_plakano,
    il.ilad,
    ilce.ilceno,
    ilce.ilcead,
    ilce.acikadres
   FROM ((public.il
     JOIN public.teslimatadres ON ((il.il_plakano = teslimatadres.teslimatno)))
     JOIN public.ilce ON ((il.il_plakano = ilce.ilno)));


ALTER TABLE public.teslimatnoktasi OWNER TO postgres;

--
-- TOC entry 234 (class 1259 OID 16897)
-- Name: urunkontrol; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.urunkontrol AS
 SELECT urun.urunno,
    urun.magazano,
    magaza.magazaad,
    urun.urunad,
    urun.urunfiyat,
    urun.urunstok,
    urun.kategorino,
    kategori.kategoriad,
    urun.markano,
    marka.markaad
   FROM (((public.urun
     JOIN public.magaza ON ((urun.magazano = magaza.magazano)))
     JOIN public.marka ON ((urun.markano = marka.markano)))
     JOIN public.kategori ON ((urun.kategorino = kategori.kategorino)));


ALTER TABLE public.urunkontrol OWNER TO postgres;

--
-- TOC entry 3483 (class 0 OID 16681)
-- Dependencies: 218
-- Data for Name: kargofirma; Type: TABLE DATA; Schema: kisi; Owner: postgres
--

COPY kisi.kargofirma (kisino, kfirmaad) FROM stdin;
10	Fast Kargo
12	Ziraat Kargo
11	Ptt Kargo
9	Uzay Kargo
\.


--
-- TOC entry 3480 (class 0 OID 16666)
-- Dependencies: 215
-- Data for Name: kisi; Type: TABLE DATA; Schema: kisi; Owner: postgres
--

COPY kisi.kisi (kisino, kisiad, kisisoyad, kisitel, kisitip) FROM stdin;
1	Mete	Tunç	5511065639	Müşteri
3	Ahmet	Kasap	5542237979	Müşteri
4	Feyza	Nil	5468458080	Müşteri
5	Nermin	Dağ	5432354575	Müşteri Temsilcisi
6	Halit	Irmak	5459804575	Müşteri Temsilcisi
7	Eren	Sorman	5467889999	Müşteri Temsilcisi
8	Berkay	Erbağ	5324557890	Müşteri Temsilcisi
9	Uzay	Osmanoğlu	5421234477	Kargo Firması
10	Kerem	Büyük	5421234477	Kargo Firması
11	Mehmet	Karadağ	5674557878	Kargo Firması
12	Ahmet	Karadağ	5672227878	Kargo Firması
13	Hasan	Öztürk	5667676878	Tedarikçi Firma
14	Ekrem	Toprak	5233332222	Tedarikçi Firma
15	Berke	Tunç	5556678888	Tedarikçi Firma
16	İrem	Pınar	5464443434	Tedarikçi Firma
2	Yusuf	Tunç	5434582390	Müşteri
\.


--
-- TOC entry 3481 (class 0 OID 16671)
-- Dependencies: 216
-- Data for Name: musteri; Type: TABLE DATA; Schema: kisi; Owner: postgres
--

COPY kisi.musteri (kisino, email) FROM stdin;
1	Mete@hotmail.com
2	Yusuf@hotmail.com
3	Ahmet@hotmail.com
4	Feyza@hotmail.com
\.


--
-- TOC entry 3482 (class 0 OID 16676)
-- Dependencies: 217
-- Data for Name: musteritemsilci; Type: TABLE DATA; Schema: kisi; Owner: postgres
--

COPY kisi.musteritemsilci (kisino) FROM stdin;
5
6
7
8
\.


--
-- TOC entry 3484 (class 0 OID 16686)
-- Dependencies: 219
-- Data for Name: tedarikfirma; Type: TABLE DATA; Schema: kisi; Owner: postgres
--

COPY kisi.tedarikfirma (kisino, tfirmaad) FROM stdin;
15	Saray Ltd.
14	Kaymak Ltd.
13	Metro Ltd.
16	Pınar Ltd.
\.


--
-- TOC entry 3494 (class 0 OID 16857)
-- Dependencies: 229
-- Data for Name: fatura; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.fatura (faturano, tutar, tarih, siparisno) FROM stdin;
1	10000	25.10.2022	1
3	13000	30.11.2022	3
4	800	10.09.2022	4
2	400	22.10.2022	2
\.


--
-- TOC entry 3487 (class 0 OID 16721)
-- Dependencies: 222
-- Data for Name: il; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.il (il_plakano, ilad) FROM stdin;
1	Adana
55	Samsun
34	İstanbul
54	Sakarya
56	Sinop
6	Ankara
67	Zonguldak
7	Antalya
81	Düzce
\.


--
-- TOC entry 3493 (class 0 OID 16796)
-- Dependencies: 228
-- Data for Name: ilce; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.ilce (ilceno, ilcead, acikadres, ilno) FROM stdin;
2	İlkadım	Esenler Mah...	55
1	Atakum	Kalkanca Mah...	55
3	Çaycuma	311. Mah....	67
4	Adapazarı	Şeker Sokak...	54
\.


--
-- TOC entry 3491 (class 0 OID 16751)
-- Dependencies: 226
-- Data for Name: kategori; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.kategori (kategorino, kategoriad) FROM stdin;
1	Beyaz Eşya
2	Küçük Ev Aletleri
3	Bilgisayar
4	Telefon
5	Giyim
6	Saat
7	Gözlük
\.


--
-- TOC entry 3488 (class 0 OID 16736)
-- Dependencies: 223
-- Data for Name: kurye; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.kurye (kuryeno, kfirmano, arac) FROM stdin;
1	9	Araba
2	9	Motor
3	10	Araba
4	10	Motor
5	11	Araba
6	11	Motor
7	12	Araba
8	12	Motor
9	12	Araba
10	11	Motor
\.


--
-- TOC entry 3489 (class 0 OID 16741)
-- Dependencies: 224
-- Data for Name: magaza; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.magaza (magazano, magazaad, magazaadres, magazatel, tfirmano) FROM stdin;
1	Piazza	Samsun İlkadım	5456778989	13
2	YeşilYurt	Ordu	5456678899	14
3	Serdivan Avm	Sakarya	5456678899	13
4	Çayır Avm	Trabzon	5433378899	16
\.


--
-- TOC entry 3492 (class 0 OID 16756)
-- Dependencies: 227
-- Data for Name: marka; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.marka (markano, markaad) FROM stdin;
1	Adidas
2	Nike
3	Msi
4	Asus
5	Hammer Jack
6	Grand Romanson
7	Koton
8	İntel
\.


--
-- TOC entry 3495 (class 0 OID 16945)
-- Dependencies: 238
-- Data for Name: sayi; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.sayi (sayino, sayiad, sayitoplam) FROM stdin;
3	Ürün Sayısı =	5
1	Kişi Sayısı =	16
2	Sipariş Sayısı =	4
\.


--
-- TOC entry 3485 (class 0 OID 16711)
-- Dependencies: 220
-- Data for Name: siparis; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.siparis (siparisno, musterino, musteritemsilcino, teslimatno, kuryeno, urunno) FROM stdin;
4	4	7	1	5	1
3	3	5	2	7	3
1	1	5	2	3	4
2	2	7	3	6	5
\.


--
-- TOC entry 3486 (class 0 OID 16716)
-- Dependencies: 221
-- Data for Name: teslimatadres; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.teslimatadres (teslimatno, ilno) FROM stdin;
1	1
2	55
3	67
4	54
\.


--
-- TOC entry 3490 (class 0 OID 16746)
-- Dependencies: 225
-- Data for Name: urun; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.urun (urunno, magazano, urunad, urunfiyat, urunstok, kategorino, markano) FROM stdin;
1	1	Ayakkabı	800	500	5	1
4	3	Laptop	10000	1000	3	3
2	1	Ryzan01	900	500	7	6
3	2	i5 13th	13000	300	3	8
5	2	Kot Pantolon	400	1200	5	7
\.


--
-- TOC entry 3282 (class 2606 OID 16685)
-- Name: kargofirma kargofirma_pk; Type: CONSTRAINT; Schema: kisi; Owner: postgres
--

ALTER TABLE ONLY kisi.kargofirma
    ADD CONSTRAINT kargofirma_pk PRIMARY KEY (kisino);


--
-- TOC entry 3276 (class 2606 OID 16670)
-- Name: kisi kisi_pk; Type: CONSTRAINT; Schema: kisi; Owner: postgres
--

ALTER TABLE ONLY kisi.kisi
    ADD CONSTRAINT kisi_pk PRIMARY KEY (kisino);


--
-- TOC entry 3278 (class 2606 OID 16675)
-- Name: musteri musteri_pk; Type: CONSTRAINT; Schema: kisi; Owner: postgres
--

ALTER TABLE ONLY kisi.musteri
    ADD CONSTRAINT musteri_pk PRIMARY KEY (kisino);


--
-- TOC entry 3280 (class 2606 OID 16680)
-- Name: musteritemsilci musteritemsilci_pk; Type: CONSTRAINT; Schema: kisi; Owner: postgres
--

ALTER TABLE ONLY kisi.musteritemsilci
    ADD CONSTRAINT musteritemsilci_pk PRIMARY KEY (kisino);


--
-- TOC entry 3284 (class 2606 OID 16690)
-- Name: tedarikfirma tedarikfirma_pk; Type: CONSTRAINT; Schema: kisi; Owner: postgres
--

ALTER TABLE ONLY kisi.tedarikfirma
    ADD CONSTRAINT tedarikfirma_pk PRIMARY KEY (kisino);


--
-- TOC entry 3304 (class 2606 OID 16861)
-- Name: fatura fatura_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.fatura
    ADD CONSTRAINT fatura_pkey PRIMARY KEY (faturano);


--
-- TOC entry 3290 (class 2606 OID 16725)
-- Name: il il_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.il
    ADD CONSTRAINT il_pkey PRIMARY KEY (il_plakano);


--
-- TOC entry 3302 (class 2606 OID 16800)
-- Name: ilce ilce_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ilce
    ADD CONSTRAINT ilce_pkey PRIMARY KEY (ilceno);


--
-- TOC entry 3298 (class 2606 OID 16755)
-- Name: kategori kategori_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kategori
    ADD CONSTRAINT kategori_pkey PRIMARY KEY (kategorino);


--
-- TOC entry 3292 (class 2606 OID 16740)
-- Name: kurye kurye_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kurye
    ADD CONSTRAINT kurye_pkey PRIMARY KEY (kuryeno);


--
-- TOC entry 3294 (class 2606 OID 16745)
-- Name: magaza magaza_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.magaza
    ADD CONSTRAINT magaza_pkey PRIMARY KEY (magazano);


--
-- TOC entry 3300 (class 2606 OID 16760)
-- Name: marka marka_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.marka
    ADD CONSTRAINT marka_pkey PRIMARY KEY (markano);


--
-- TOC entry 3306 (class 2606 OID 16949)
-- Name: sayi sayi_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sayi
    ADD CONSTRAINT sayi_pkey PRIMARY KEY (sayino);


--
-- TOC entry 3286 (class 2606 OID 16715)
-- Name: siparis siparis_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.siparis
    ADD CONSTRAINT siparis_pkey PRIMARY KEY (siparisno);


--
-- TOC entry 3288 (class 2606 OID 16720)
-- Name: teslimatadres teslimatadres_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.teslimatadres
    ADD CONSTRAINT teslimatadres_pkey PRIMARY KEY (teslimatno);


--
-- TOC entry 3296 (class 2606 OID 16750)
-- Name: urun urun_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.urun
    ADD CONSTRAINT urun_pkey PRIMARY KEY (urunno);


--
-- TOC entry 3324 (class 2620 OID 16951)
-- Name: kisi kisiekle; Type: TRIGGER; Schema: kisi; Owner: postgres
--

CREATE TRIGGER kisiekle AFTER INSERT ON kisi.kisi FOR EACH ROW EXECUTE FUNCTION public.kisiekle();


--
-- TOC entry 3325 (class 2620 OID 16953)
-- Name: kisi kisisil; Type: TRIGGER; Schema: kisi; Owner: postgres
--

CREATE TRIGGER kisisil AFTER DELETE ON kisi.kisi FOR EACH ROW EXECUTE FUNCTION public.kisisil();


--
-- TOC entry 3326 (class 2620 OID 16959)
-- Name: siparis siparisekle; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER siparisekle AFTER INSERT ON public.siparis FOR EACH ROW EXECUTE FUNCTION public.siparisekle();


--
-- TOC entry 3327 (class 2620 OID 16961)
-- Name: siparis siparissil; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER siparissil AFTER DELETE ON public.siparis FOR EACH ROW EXECUTE FUNCTION public.siparissil();


--
-- TOC entry 3328 (class 2620 OID 16955)
-- Name: urun urunekle; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER urunekle AFTER INSERT ON public.urun FOR EACH ROW EXECUTE FUNCTION public.urunekle();


--
-- TOC entry 3329 (class 2620 OID 16957)
-- Name: urun urunsil; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER urunsil AFTER DELETE ON public.urun FOR EACH ROW EXECUTE FUNCTION public.urunsil();


--
-- TOC entry 3309 (class 2606 OID 16701)
-- Name: kargofirma kisikarkargofirma_fk; Type: FK CONSTRAINT; Schema: kisi; Owner: postgres
--

ALTER TABLE ONLY kisi.kargofirma
    ADD CONSTRAINT kisikarkargofirma_fk FOREIGN KEY (kisino) REFERENCES kisi.kisi(kisino) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3307 (class 2606 OID 16691)
-- Name: musteri kisimusteri_fk; Type: FK CONSTRAINT; Schema: kisi; Owner: postgres
--

ALTER TABLE ONLY kisi.musteri
    ADD CONSTRAINT kisimusteri_fk FOREIGN KEY (kisino) REFERENCES kisi.kisi(kisino) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3308 (class 2606 OID 16696)
-- Name: musteritemsilci kisimusteritemsilci_fk; Type: FK CONSTRAINT; Schema: kisi; Owner: postgres
--

ALTER TABLE ONLY kisi.musteritemsilci
    ADD CONSTRAINT kisimusteritemsilci_fk FOREIGN KEY (kisino) REFERENCES kisi.kisi(kisino) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3310 (class 2606 OID 16706)
-- Name: tedarikfirma kisitedarikfirma_fk; Type: FK CONSTRAINT; Schema: kisi; Owner: postgres
--

ALTER TABLE ONLY kisi.tedarikfirma
    ADD CONSTRAINT kisitedarikfirma_fk FOREIGN KEY (kisino) REFERENCES kisi.kisi(kisino) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3323 (class 2606 OID 16862)
-- Name: fatura faturasiparis; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.fatura
    ADD CONSTRAINT faturasiparis FOREIGN KEY (siparisno) REFERENCES public.siparis(siparisno) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3322 (class 2606 OID 16801)
-- Name: ilce ilceil; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ilce
    ADD CONSTRAINT ilceil FOREIGN KEY (ilno) REFERENCES public.il(il_plakano) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3317 (class 2606 OID 16766)
-- Name: kurye kuryekfirma; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kurye
    ADD CONSTRAINT kuryekfirma FOREIGN KEY (kfirmano) REFERENCES kisi.kargofirma(kisino) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3318 (class 2606 OID 16771)
-- Name: magaza magazatedarik; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.magaza
    ADD CONSTRAINT magazatedarik FOREIGN KEY (tfirmano) REFERENCES kisi.tedarikfirma(kisino) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3311 (class 2606 OID 16821)
-- Name: siparis sipariskurye; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.siparis
    ADD CONSTRAINT sipariskurye FOREIGN KEY (kuryeno) REFERENCES public.kurye(kuryeno) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3312 (class 2606 OID 16811)
-- Name: siparis siparismusteri; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.siparis
    ADD CONSTRAINT siparismusteri FOREIGN KEY (musterino) REFERENCES kisi.musteri(kisino) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3313 (class 2606 OID 16816)
-- Name: siparis siparismusteritemsilci; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.siparis
    ADD CONSTRAINT siparismusteritemsilci FOREIGN KEY (musteritemsilcino) REFERENCES kisi.musteritemsilci(kisino) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3314 (class 2606 OID 16826)
-- Name: siparis siparisteslimat; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.siparis
    ADD CONSTRAINT siparisteslimat FOREIGN KEY (teslimatno) REFERENCES public.teslimatadres(teslimatno) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3315 (class 2606 OID 16887)
-- Name: siparis siparisurun; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.siparis
    ADD CONSTRAINT siparisurun FOREIGN KEY (urunno) REFERENCES public.urun(urunno) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3316 (class 2606 OID 16806)
-- Name: teslimatadres teslimatil; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.teslimatadres
    ADD CONSTRAINT teslimatil FOREIGN KEY (ilno) REFERENCES public.il(il_plakano) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3319 (class 2606 OID 16776)
-- Name: urun urunkategori; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.urun
    ADD CONSTRAINT urunkategori FOREIGN KEY (kategorino) REFERENCES public.kategori(kategorino) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3320 (class 2606 OID 16786)
-- Name: urun urunmagaza; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.urun
    ADD CONSTRAINT urunmagaza FOREIGN KEY (magazano) REFERENCES public.magaza(magazano) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3321 (class 2606 OID 16781)
-- Name: urun urunmarka; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.urun
    ADD CONSTRAINT urunmarka FOREIGN KEY (markano) REFERENCES public.marka(markano) ON UPDATE CASCADE ON DELETE CASCADE;


-- Completed on 2022-12-27 22:27:07

--
-- PostgreSQL database dump complete
--

