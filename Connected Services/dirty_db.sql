PGDMP      !                |            postgres    16.1    16.1 B               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    5    postgres    DATABASE     |   CREATE DATABASE postgres WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE postgres;
                postgres    false                       0    0    DATABASE postgres    COMMENT     N   COMMENT ON DATABASE postgres IS 'default administrative connection database';
                   postgres    false    4879                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
                pg_database_owner    false                       0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                   pg_database_owner    false    5            �            1255    16629 $   get_accruals(integer, integer, real) 	   PROCEDURE     �  CREATE PROCEDURE public.get_accruals(IN ai_id_garage integer DEFAULT 0, IN ai_id_account integer DEFAULT 0, IN ar_sum real DEFAULT (0)::real)
    LANGUAGE plpgsql
    AS $$declare
li_cnt integer;
li_id_acc_electr integer;
li_id_acc_el_day integer;
li_id_acc_el_night integer;
li_id_account integer;
begin
select id_account into li_id_acc_el_day
from s_account
where name_account = 'Электричество, день';

select id_account into li_id_acc_el_night
from s_account
where name_account = 'Электричество, ночь';

select id_account into li_id_acc_electr
from s_account
where name_account = 'Электричество (общее)';

if (ai_id_account != li_id_acc_el_day) and (ai_id_account != li_id_acc_el_night) then
	li_id_account = ai_id_account;
else
	li_id_account = li_id_acc_electr;
end if;

select count(*) into li_cnt 
from t_sum 
where id_garage = ai_id_garage 
and id_account = li_id_account;

if li_cnt > 0 then
	update t_sum set debt = debt + ar_sum, 
					 sum = ar_sum, 
					 date_upd_ins = current_date 
	where id_garage = ai_id_garage 
	and id_account = li_id_account;
else
	insert into t_sum (id_garage, id_account, date_upd_ins, sum, debt) values (ai_id_garage, li_id_account, current_date, ar_sum, 0);
end if;
end;$$;
 g   DROP PROCEDURE public.get_accruals(IN ai_id_garage integer, IN ai_id_account integer, IN ar_sum real);
       public          postgres    false    5                       0    0 Y   PROCEDURE get_accruals(IN ai_id_garage integer, IN ai_id_account integer, IN ar_sum real)    ACL     �  REVOKE ALL ON PROCEDURE public.get_accruals(IN ai_id_garage integer, IN ai_id_account integer, IN ar_sum real) FROM PUBLIC;
REVOKE ALL ON PROCEDURE public.get_accruals(IN ai_id_garage integer, IN ai_id_account integer, IN ar_sum real) FROM postgres;
GRANT ALL ON PROCEDURE public.get_accruals(IN ai_id_garage integer, IN ai_id_account integer, IN ar_sum real) TO postgres WITH GRANT OPTION;
          public          postgres    false    250            �            1255    16613    log_info(text, text, text) 	   PROCEDURE     ~  CREATE PROCEDURE public.log_info(IN as_login text DEFAULT NULL::text, IN as_action text DEFAULT NULL::text, IN as_note text DEFAULT NULL::text)
    LANGUAGE plpgsql
    AS $$declare
li_user integer;
begin
select id_user into li_user from s_users where login = as_login;
insert into t_log (id_user, date_act, action, note) values (li_user, current_date, as_action, as_note);
end;$$;
 V   DROP PROCEDURE public.log_info(IN as_login text, IN as_action text, IN as_note text);
       public          postgres    false    5                       0    0 H   PROCEDURE log_info(IN as_login text, IN as_action text, IN as_note text)    ACL     T  REVOKE ALL ON PROCEDURE public.log_info(IN as_login text, IN as_action text, IN as_note text) FROM PUBLIC;
REVOKE ALL ON PROCEDURE public.log_info(IN as_login text, IN as_action text, IN as_note text) FROM postgres;
GRANT ALL ON PROCEDURE public.log_info(IN as_login text, IN as_action text, IN as_note text) TO postgres WITH GRANT OPTION;
          public          postgres    false    249            �            1259    16398 	   s_account    TABLE     �   CREATE TABLE public.s_account (
    id_account integer NOT NULL,
    name_account text,
    note text,
    id_type_account integer NOT NULL
);
    DROP TABLE public.s_account;
       public         heap    postgres    false    5            �            1259    16397    s_account_id_account_seq    SEQUENCE     �   ALTER TABLE public.s_account ALTER COLUMN id_account ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.s_account_id_account_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    5    217            �            1259    16420    s_account_type    TABLE     x   CREATE TABLE public.s_account_type (
    id_account_type integer NOT NULL,
    name_account_type text,
    note text
);
 "   DROP TABLE public.s_account_type;
       public         heap    postgres    false    5            �            1259    16419 "   s_account_type_id_account_type_seq    SEQUENCE     �   ALTER TABLE public.s_account_type ALTER COLUMN id_account_type ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.s_account_type_id_account_type_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    5    223            �            1259    16464    s_garage_types    TABLE     v   CREATE TABLE public.s_garage_types (
    id_garage_type integer NOT NULL,
    name_garage_type text,
    note text
);
 "   DROP TABLE public.s_garage_types;
       public         heap    postgres    false    5            �            1259    16463 !   s_garage_types_id_garage_type_seq    SEQUENCE     �   ALTER TABLE public.s_garage_types ALTER COLUMN id_garage_type ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.s_garage_types_id_garage_type_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    231    5            �            1259    16472 	   s_persons    TABLE     �   CREATE TABLE public.s_persons (
    id_person integer NOT NULL,
    fio text,
    note text,
    phone_number text,
    address text,
    is_user integer,
    is_owner integer,
    is_payer integer
);
    DROP TABLE public.s_persons;
       public         heap    postgres    false    5            �            1259    16471    s_persons_id_person_seq    SEQUENCE     �   ALTER TABLE public.s_persons ALTER COLUMN id_person ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.s_persons_id_person_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    5    233            �            1259    16406    s_si    TABLE     Z   CREATE TABLE public.s_si (
    id_si integer NOT NULL,
    name_si text,
    note text
);
    DROP TABLE public.s_si;
       public         heap    postgres    false    5            �            1259    16405    s_si_id_si_seq    SEQUENCE     �   ALTER TABLE public.s_si ALTER COLUMN id_si ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.s_si_id_si_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    5    219            �            1259    16480    s_users    TABLE     �   CREATE TABLE public.s_users (
    id_user integer NOT NULL,
    date_reg date,
    login text,
    note text,
    id_person integer
);
    DROP TABLE public.s_users;
       public         heap    postgres    false    5            �            1259    16479    s_users_id_user_seq    SEQUENCE     �   ALTER TABLE public.s_users ALTER COLUMN id_user ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.s_users_id_user_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    235    5            �            1259    16414    t_acc_value    TABLE     �   CREATE TABLE public.t_acc_value (
    id_acc_value integer NOT NULL,
    id_account integer,
    date_on date,
    date_off date,
    value_fare real,
    id_si integer,
    id_garage_type integer
);
    DROP TABLE public.t_acc_value;
       public         heap    postgres    false    5            �            1259    16413    t_acc_value_id_acc_value_seq    SEQUENCE     �   ALTER TABLE public.t_acc_value ALTER COLUMN id_acc_value ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.t_acc_value_id_acc_value_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    221    5            �            1259    16440 	   t_garages    TABLE     �   CREATE TABLE public.t_garages (
    id_garage integer NOT NULL,
    id_owner integer,
    num text,
    date_in date,
    fio text,
    address text,
    note text,
    id_garage_type integer
);
    DROP TABLE public.t_garages;
       public         heap    postgres    false    5            �            1259    16439    t_garages_id_garage_seq    SEQUENCE     �   ALTER TABLE public.t_garages ALTER COLUMN id_garage ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.t_garages_id_garage_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    229    5            �            1259    16488    t_log    TABLE     �   CREATE TABLE public.t_log (
    id_log integer NOT NULL,
    id_user integer,
    date_act date,
    action text,
    note text
);
    DROP TABLE public.t_log;
       public         heap    postgres    false    5            �            1259    16487    t_log_id_log_seq    SEQUENCE     �   ALTER TABLE public.t_log ALTER COLUMN id_log ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.t_log_id_log_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    237    5            �            1259    16428 
   t_payments    TABLE     �   CREATE TABLE public.t_payments (
    id_payment integer NOT NULL,
    id_garage integer,
    id_account integer,
    meter_data real,
    pay_sum real,
    id_payer integer,
    date_payment date,
    fio text,
    num text
);
    DROP TABLE public.t_payments;
       public         heap    postgres    false    5            �            1259    16427    t_payments_id_payment_seq    SEQUENCE     �   ALTER TABLE public.t_payments ALTER COLUMN id_payment ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.t_payments_id_payment_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    225    5            �            1259    16434    t_sum    TABLE     �   CREATE TABLE public.t_sum (
    id_sum integer NOT NULL,
    id_garage integer,
    date_upd_ins date,
    sum real,
    debt real,
    fio text,
    date_in date,
    num text,
    id_type_garage integer,
    id_account integer
);
    DROP TABLE public.t_sum;
       public         heap    postgres    false    5            �            1259    16433    t_sum_id_sum_seq    SEQUENCE     �   ALTER TABLE public.t_sum ALTER COLUMN id_sum ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.t_sum_id_sum_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    227    5            �          0    16398 	   s_account 
   TABLE DATA           T   COPY public.s_account (id_account, name_account, note, id_type_account) FROM stdin;
    public          postgres    false    217   ZR       �          0    16420    s_account_type 
   TABLE DATA           R   COPY public.s_account_type (id_account_type, name_account_type, note) FROM stdin;
    public          postgres    false    223   �T                 0    16464    s_garage_types 
   TABLE DATA           P   COPY public.s_garage_types (id_garage_type, name_garage_type, note) FROM stdin;
    public          postgres    false    231   uU                 0    16472 	   s_persons 
   TABLE DATA           m   COPY public.s_persons (id_person, fio, note, phone_number, address, is_user, is_owner, is_payer) FROM stdin;
    public          postgres    false    233   �U       �          0    16406    s_si 
   TABLE DATA           4   COPY public.s_si (id_si, name_si, note) FROM stdin;
    public          postgres    false    219   k                 0    16480    s_users 
   TABLE DATA           L   COPY public.s_users (id_user, date_reg, login, note, id_person) FROM stdin;
    public          postgres    false    235   �k       �          0    16414    t_acc_value 
   TABLE DATA           u   COPY public.t_acc_value (id_acc_value, id_account, date_on, date_off, value_fare, id_si, id_garage_type) FROM stdin;
    public          postgres    false    221   �k                 0    16440 	   t_garages 
   TABLE DATA           j   COPY public.t_garages (id_garage, id_owner, num, date_in, fio, address, note, id_garage_type) FROM stdin;
    public          postgres    false    229   �m       	          0    16488    t_log 
   TABLE DATA           H   COPY public.t_log (id_log, id_user, date_act, action, note) FROM stdin;
    public          postgres    false    237   �       �          0    16428 
   t_payments 
   TABLE DATA           ~   COPY public.t_payments (id_payment, id_garage, id_account, meter_data, pay_sum, id_payer, date_payment, fio, num) FROM stdin;
    public          postgres    false    225   ف       �          0    16434    t_sum 
   TABLE DATA           z   COPY public.t_sum (id_sum, id_garage, date_upd_ins, sum, debt, fio, date_in, num, id_type_garage, id_account) FROM stdin;
    public          postgres    false    227   `�                  0    0    s_account_id_account_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.s_account_id_account_seq', 29, true);
          public          postgres    false    216                       0    0 "   s_account_type_id_account_type_seq    SEQUENCE SET     P   SELECT pg_catalog.setval('public.s_account_type_id_account_type_seq', 4, true);
          public          postgres    false    222                       0    0 !   s_garage_types_id_garage_type_seq    SEQUENCE SET     O   SELECT pg_catalog.setval('public.s_garage_types_id_garage_type_seq', 5, true);
          public          postgres    false    230                       0    0    s_persons_id_person_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.s_persons_id_person_seq', 296, true);
          public          postgres    false    232                       0    0    s_si_id_si_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.s_si_id_si_seq', 3, true);
          public          postgres    false    218                       0    0    s_users_id_user_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.s_users_id_user_seq', 1, true);
          public          postgres    false    234                       0    0    t_acc_value_id_acc_value_seq    SEQUENCE SET     K   SELECT pg_catalog.setval('public.t_acc_value_id_acc_value_seq', 75, true);
          public          postgres    false    220                       0    0    t_garages_id_garage_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.t_garages_id_garage_seq', 470, true);
          public          postgres    false    228                       0    0    t_log_id_log_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.t_log_id_log_seq', 63, true);
          public          postgres    false    236                       0    0    t_payments_id_payment_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.t_payments_id_payment_seq', 394, true);
          public          postgres    false    224                       0    0    t_sum_id_sum_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.t_sum_id_sum_seq', 2850, true);
          public          postgres    false    226            P           2606    16404    s_account s_account_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.s_account
    ADD CONSTRAINT s_account_pkey PRIMARY KEY (id_account);
 B   ALTER TABLE ONLY public.s_account DROP CONSTRAINT s_account_pkey;
       public            postgres    false    217            V           2606    16426 "   s_account_type s_account_type_pkey 
   CONSTRAINT     m   ALTER TABLE ONLY public.s_account_type
    ADD CONSTRAINT s_account_type_pkey PRIMARY KEY (id_account_type);
 L   ALTER TABLE ONLY public.s_account_type DROP CONSTRAINT s_account_type_pkey;
       public            postgres    false    223            ^           2606    16470 "   s_garage_types s_garage_types_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public.s_garage_types
    ADD CONSTRAINT s_garage_types_pkey PRIMARY KEY (id_garage_type);
 L   ALTER TABLE ONLY public.s_garage_types DROP CONSTRAINT s_garage_types_pkey;
       public            postgres    false    231            `           2606    16478    s_persons s_persons_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.s_persons
    ADD CONSTRAINT s_persons_pkey PRIMARY KEY (id_person);
 B   ALTER TABLE ONLY public.s_persons DROP CONSTRAINT s_persons_pkey;
       public            postgres    false    233            R           2606    16412    s_si s_si_pkey 
   CONSTRAINT     O   ALTER TABLE ONLY public.s_si
    ADD CONSTRAINT s_si_pkey PRIMARY KEY (id_si);
 8   ALTER TABLE ONLY public.s_si DROP CONSTRAINT s_si_pkey;
       public            postgres    false    219            b           2606    16486    s_users s_users_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.s_users
    ADD CONSTRAINT s_users_pkey PRIMARY KEY (id_user);
 >   ALTER TABLE ONLY public.s_users DROP CONSTRAINT s_users_pkey;
       public            postgres    false    235            T           2606    16418    t_acc_value t_acc_value_pkey 
   CONSTRAINT     d   ALTER TABLE ONLY public.t_acc_value
    ADD CONSTRAINT t_acc_value_pkey PRIMARY KEY (id_acc_value);
 F   ALTER TABLE ONLY public.t_acc_value DROP CONSTRAINT t_acc_value_pkey;
       public            postgres    false    221            \           2606    16446    t_garages t_garages_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.t_garages
    ADD CONSTRAINT t_garages_pkey PRIMARY KEY (id_garage);
 B   ALTER TABLE ONLY public.t_garages DROP CONSTRAINT t_garages_pkey;
       public            postgres    false    229            d           2606    16494    t_log t_log_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.t_log
    ADD CONSTRAINT t_log_pkey PRIMARY KEY (id_log);
 :   ALTER TABLE ONLY public.t_log DROP CONSTRAINT t_log_pkey;
       public            postgres    false    237            X           2606    16432    t_payments t_payments_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.t_payments
    ADD CONSTRAINT t_payments_pkey PRIMARY KEY (id_payment);
 D   ALTER TABLE ONLY public.t_payments DROP CONSTRAINT t_payments_pkey;
       public            postgres    false    225            Z           2606    16438    t_sum t_sum_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.t_sum
    ADD CONSTRAINT t_sum_pkey PRIMARY KEY (id_sum);
 :   ALTER TABLE ONLY public.t_sum DROP CONSTRAINT t_sum_pkey;
       public            postgres    false    227            �     x��U�N"A}����On7L3��~���5�zy2&J�e��d�� �U��:�App����9U]�@Q�"�鑦4�84�)7�r�"nr�O5=�7`�*��~�7�6������p�ۚ��zh?�4T�g��1�L�1��~Z��Q�d=A�k�x��R��]���A耢9�/�I���cq�M�*��mJAy�/u���-#Wre��5�|��_�ڬ�u�X-�1(9�ZQ����Ei�)M�(ʲ����)��M�ublL�F��:J6�D7��=3��	wN�o����)e<�u�2�;3ST�L��H���ZBH��f�jk\%�Sz\P�k�%�G��+=q���]A��x`7P�ʞt�?Y z�k�^�	��$i3�) g	��{`*���������>�j�g��ޡ[�M���KH�|Z���ǳB��D�l��ҝΈ&���>��dU��d�$"!�*a��W$�wt�=� �7ܶ�N��r�2��
�}���hM@���;K�9�����L ��21�?��a<���y���d      �   �   x�u���0E�vS �XN�B1Y@ ��DHH���tķ��_fhp��i�Z�4�gx�nhu�J��H̾B��;j�\x��:t�<΂K4:\Y�t.f�FAPRm�装ׅvd�!O�7g��`ˉ�9^��ʫG�gf\E�@=�,��JX�֔�U��]~"O�s<�?�I�v!���`O_0sk��&|�QJWx����Z���um�=k�S��         x   x�m�A
�PE���o�@�m��B�h �� �H�)�_�y;���.�\N"4t|<of;�^�v��gM����h���GFѝp�k�I��S���?�?�^�S����ȓ(�A�~�Y�            x��\irG����C�����������`CRIv��4���S�7��mPHpx���I&3k� )6��dk!����r�2��b��մ�ï�rg���r���;|T���yu��a�t�[M���xb���zV�c���)|ࠚ,Tg�ɪ}�:��O���������1�X�B(����(���~V�O����]�Gu��G��8
���ܩNa���N��9<p�	3-`�9����/��N�gH�&��_,�	�|��{��dS��՗M.�.0�+8��Na�)R��氤m���0�.���ܰ27jt=������G n�X��O�o0�9�F3��vy�H��r��ϗq���C:���	f݁��x��/x�hߦ�jkZ1��ͯ�<�Ӌ~������:,�����?�w����ș-�F����VR��Ɖ�n"��ϟ��[�A�-��e����9���$��.�W�RW'|�T#;;�
�i�֜[!�.X�Ҽ����[����~'QA�\,wh�q���	��q���� ,�߸���#1ބ�a,ƸfV��u�������">�n��u�vOp�Q�1ri����/e�eH�^\HZ���"���*��qu�X�{S��NY�6���)P0Y���k_	�<����	ؓ��}�	^-��1�@�~Oڶ��(�⹌��yA�uu\V��y��jT�09�ʹ�?�Gy�Y?MF�݈{��A�9c���@'j6Z�coX� �Vq�g��F��`�4@�)錙�nO��;t�FQE���mw��5�ޟvGН�:���`���ŵ�B��i�A�9iŜ(�����8�Jl��7�[tu�PDj,fGx#,H���'� �g��۝zV}��܀w�)��~��=X�-�U�G���t�.����Ľ�'�C0Cnm��g�p�v_����^���քc^8=5s���Qy�1U�	^�b<��~\S��z�^�����֍i��+��������RL ����!�uJ��8.qeǙxՈ�<q����ˣJ�˛��}�D�S�[@��ܦ����-=��OYsm��[�ہ�W(�m�m$xe��$���P�bw}�#"'�,_X��Ȁ��K+��s�12D])�h��@:[��)����Ȳ��ì�M�����p�n���kg/�	Ǔ6�h�7��	ڞu�]f�;��I3 �`!m�T�gqk��k��~,p7��������;0�U:'�(L�lT���
���̱e�K���#Ү/Z\br���19:��m�rSǃ��;�� j�ӎ�_�jQh1����:���R�4n��]d�Þ����̎�*��Y<������������'C������t�5�N��̄���4A�}A���a���l�nH�G��r��سh�������]/);K�8�i;=~�Tv�0^h�k�V��Q|+���_�Ϫr�aq���7�`�G.z=���ޜ#��\o�]>"@1�5��9Y�J#嵖����a���3>
���Ct��`ei�p �9���Kn�.n޳4�Hs��1l�S��>#�p�{6��N-�^B�ݹh�κyˌ�4�c�%���E�'��<���ܻ�5'�-��PEnt���ρq�L)�� �S�N������8����(&T�(@��6�&=N[�(�〛��8(�ߣ��%�v�v�g�`�T��tb��^L�[�ׄ̕H�;a�<5�r7ץ����g6˕걓�hL�0CD��
ZHrL�+�KA_ah�y:؃���QZ�&y| v�Ll&��3����ё@Aນ��ßdc��S�"���lp�p�L�TQ0P�(���A�����:�ݱ�y���YzE��~j�b��0�:Z��kR�(��涸���M('	�E�ߐCx��n!�~�um֓��"��g3�%4�O�`�]��4D����#]��Uj6��rJ��w��Ӣ�.�8S�3�Z�����`�$ԈfLʜ��Z�[:{���qWAs�"�H��
x(Z�ښ-Zc<a�R7��Omɉg���A?�?$/�*�EB?&ӌ�8�eڛKXd��8���;l[Z�<$�E���ɵ�˚� 0�l���hV�Jj�j��- �
�ǡ��+"+/�:�ܜ�0�t�;�����Ps��yQ���+����9�c�A�9x���--�[ƀ�+!XO䚦�#y|���Z}��|AB���I:"�r��ص��[Z!��ē���mJx�rcV�4��W������M@w}��(̍�W���c��4��f̰lll�����q��Bdpm�?���-]����My���6a��W��{��KV
����P�]�_�*�<����%<n����@�v�3|��s�b.�bS���]�y����Z��� 	�kA9��JJ����}j���@�N��������!�V�rS����� A�Tk]H]��}�R��lQ��P��� c��g��v���ֽ�2k�Y.� )�d-��L��p%�`2��[��l��uh�9+��գ���Ҡ��uސ}	���6�M�<.�`L 4}դNj��E>zo���c+�b����ʽ퍑��(q���
��]��>l~�f�p;{�[����Np���<��ɔ�H��0�rnn�,
Z���*��@��9�'�B��{{��%\��׷!2�'����(-�{�Ўw��,�j�[�a�7������Ҕvu�ʿ$���v�c�%�n�"1B#퓴�0���kE|++�ߐ:'u	e��l]��B��*e���$[6liFCh�͕�3r�>e�vm��J�w�y���b�ɭ��� ��9�����;~e����Y��K������-�2�����0���@㼥�.���6P�:��Oc�SKU^d/�k����r_�h�w�VT\�yi��1c$�h�n�6��#Ւ�����Q�X�첰K�@��u�a���(��)��K,�\�`�i��Q�߁�f�����=� �f�)e� L��5�>I$�k�
���N$wzh�@d_K)�����2�;�%@\�E"7aUܮ��'�Zl�^U�}���|-/)�]dl[�|�'���1䈠��wj2�OnCM�f�u*ͅ��*��C�fB`g��$��6� 2����( ��	��y��6w�-�����0�w���:YO���������Ǆ��9e�\%ʱ��IJ
;ά�q�`ygw.	Y֙���عRkT�j��s+*=������������ۧ�i*7ޣܼ٥�z7A�Q�b䲌�������t�S�4oC̵�L�>e��q��3.4MOx�k�u[��o�d�vmi�%L)�0\i ]��ϯu0*$�O��YH�-�Ɏ� �9�c	!��G+f G���iP����~(A������/�k�b�~�Xp-������e�F��yA

��Q�w���bET�	�@:��}�b�KV@�>kf|��̮g
�I\O�e�7R$��,�-�C��pUX�SEC�|z�Y(���-
%7�W�g��cT�3�q5Q�A�@1*n�l�{�	�ڵuC�>�[`��;"b�3����ʾ���V��?QJ�Ţ貋��M��c�ٙ]ݱ��j�mJ;��"��U$u�Z֨���~_�k9sD���b�\��*6N~�A�;���ᷯ[՜�"ݽ��C<��zs�n\=�Y�޽�B͋�����w�ɯ�(�A�x�j��5�
���4ޅߣ"Qˈ�}L�q'3��
=DE�%�j��M`��C8'�79U
��^�͏U�9!�ٓ���X�.�!r*'�yi�o߉⬗��nZA�'�/��6�Z�P������T^"�z��,b0sB�ƻ�j�]��rAEKh:N;V\��?q=����f�A�⊞z��\�8�A�pH�����7d��#�5Ӕ*l��HZuB���Khd��8F	Ч��!��hvL ��t�g^w:�Ճj#���䷲ ׇ�r/!��\Į���6�A�&�ii�yr�q�x[�mǻAZ��.�����q ����
�QH)�@�1PG���(��R����!�"�q�� �  ����bl���{�c�Y)Ֆ�I)���/&T"	�2�]L�*iM���^�O�
�%��`aE��@<�������i��w��ᓛ�Qe�݄�6�[��
Ycl�P�_TS����D������!%�4gy)�)�n�ʧh�#�|rM#]�$!�J*�W�2��B�Uf�*��o��g����Nl%(�3�Z>��b��>>)���w+.4�� .��D�^�iٵ8�kp�Ei�a|9�]lҦ�׽N��ppQ�\���&ճE �Qd�(�����kv�M�:6�H���`>A���Ų�}"��d�>��������%w=_.%G��H�F^�,E��Gi�s<��L'+�]�w�k,�g��pi�ʑ��PI��V鮬��|u��� ����nn9Pz��c���x-pT*/�zn�K���tR>z���~*�
��n��*{>;�sJ0�k8�;��q����|�E�(X�����;����ᳫ���>(cj��ҭ}��HD�`t�ͥ��7�Q�;�MV�;���V��OU.X.���NS`88��E��v�;%>[��g37�hte�����3���Q�o�� �*�Kw�YP3}qD��	�Sf���� �h��	lh\x��Ol��y1�E���%6�=�x��TU�m�/�=w:�Qj�	�%\?�c��u'j�`vz����6C1�]��DBC�����E���M��!�vm��}�&�n�����	��}�[u�YD��4֨�b�]O\�١�}�>��|�
�{n�!�I���x��_��5,m����A;q�EHp
��V��"��
DM�/0���Z����$�'j�3v���G�6V^����Y�[X���_H�V���
����B�����k_�e��a��/�._�*�^�qfd�UQR�B�N�;}�-Uv=6yxF�E�m�D�,c��Ob����4U��A�ާ_(5���XQn�`����+�����)~:�Y�S��1.0O��).���p�;���	�p#�ޣ��%1��������8^��Ico� >H�5�.%dB(�Q��櫹�����{�
AN�Wb���i�H9����C��~ۍA͜Iǥ-��{V�|��]�ؤ��̟W3���y����N��d���!)�	�l��	�P�|D
�������O紝�өa�=8�PXh��W[�@��.OJFbM�/#x�\��O�Cl ����xg�EV*wQ8�-m��u��O�\ަ�zX�{����;w��B�      �   �   x��N;�@�wO��6�:�(�&V���+g���#��JK��7yo~K�}�5�
WD�ܣv�w<�#�Ǔӿ�bA/������	��bFy���`X��������RL�2̹�%�f��4[��~/4�hn
;p���nRk����V         3   x�3�4202�50�52�0�¾{.��s��bӅ�8c�8�b���� g �      �   �  x����m�0�gq�Kt��?G閲��@���2�í��V�_��P���*�e�A�cp��HF��;���We��	뎚E�:+#����VFj0���(����tLC�$E��eߌ6���f�4n���Z��Y�\ ��H���M�#�s���#Q灷�đ+M��:��ޚz�技���D�AyK�H�\i"��H��{��H����#Q{�-�#q劀���Dֿx���|��1 ם��(T��JLI����=�"45C���Be��M5Pd�$��%�.	[?v���s�+h=	��W�*�;?wG��=0��Ư���ve��ڠ�>P�Z�0Rs'R�v-��Ϳ�\�,��Ce����i���ro7Y����{���0�{����7��w��J�����婥ύ�v+�K�-��������            x��\Yr��n�b>�@]���o��0$@ItH!��H��IӖ�C C��
=W�|g���Ϊ�n�t�?��BX�_W��2+{L�$�2�1�M��K�=[$��v��E��g���vޞ��E�a־j��w�^��t�7�~���S���619��f/-�l������)�?o��#�8k_ҏ����Y{ou@Ϙ�nkP@����1"}K�W��vu�뢅��W��a�7��|L�^�n��@��@�@/z����o���B_a�'�K��G0s���uӯ 8s(�����!�{6OX�W����c�6�D���R}Ò���0���ֈ�s���g�k^��;��%��� ��}3$_��Ħk �0IS#�,��$���=���ME�֢]D�)����~ B�{{{����º�Qu?�@�ny\��Y��E�$;y }�I=ˑ�a��X�������|/mM��5�r�U��Ջ��۪� $�Yb��^L�����]�hXvl#������)V�;�j�d�X.��h����>\��E�m�,��e,\��l�h��dg�ta+��y��X�Ia5��V�	��>��Dk�[(���t������h!�Xݙ��9pOf����5g��,�v{��(���^��tK#G������/��Q�DVD���a���V�&S�yOw-ȫו�L*hu��VțlD���M�O9�aMM��3Yc���Ѷ9F���s��N,�6? �.�B�j@�gX�P�P�2��
��/��!���[�8S�<�d�3\C2#�f�ˢ���+��\�#����ps�+�$�°}|�N{�󅬉�0�Tipݍ�y�ƬtBˠTl!y)a�!�u[��*^qw[Ѕ�4�(�8	/'W�_J&uYm�qp�DǦ}���KD�&wI��G��Tk���q�]*�>�b���7��3��6�\ﰶ9�iF>�D���&�_� O��r��>2�DK�r)��Z�4u���.���0�`D胜��E�^(������l�t�����N�\hu0�g��v��gGFꅻK�[����շ|�	2�}��cYfǒ�ے�/jL��Kb �K���
F�˟����e I�ݥ�>A�>�nwiwD��ޯ�:��ȑ�tHLG��@Ѿ d���i��A5 \]сU�r�ilY&E��5�"�^��s-�' �\�Xb�tR�4�DB��w]�_�a��v�����7*�.$�C�w��T�<�\S@UDaMRz����~�{��:.�ܓ�a�p��a[�uٸ�N)����2��߭�����JǺX`�!�).��\zq1��|��;;��>E�Gp�-���{Z}(Zx���,xVY��v�g)a��u0��� �����V��N |�G8�p^���9mؤ����._�fnIp�t$�Ӵ&����8AY�k�=���� ��2 g �@F�)	ݎV>������[YxB�{B�Dy�����arA�j��k��O]1s�s��3�5�n��&-��$p���Ty a����D��x੶M`A��H�;L���'�_���`�N�L�>�D�Lg��U�4��ς�)b㌺�=K�}�s�*�x�"UN� ���H�f�+�xU�z�Uz�Y}�c��uXZ*���pI[u��9�	����(��ps�P�$T�I�l�`�֗M�o)�c��N����U%k%#e�I{�����1��������=��i�͉���1��<iĳ�b�C	y�V�
�/�g�o(��v�\:�q-�tE뜋S�E�Z�q/���a-`aFkz�\}�"q��T���8aK��l�	��Rjrة���B�����Ī�XU��J��d�q,q{Ţ�[4�UA�����|�N� H���f;S[Vb[�:�*Ǎ�LX:1���Na��
��v��1v�	�`s F��
B���� ����s��a:?CS���I�)~fl'����0HS�M1��!B�3����t����Ad�>�n�8����c�JA@�[���ҿ�E��"D�s�,v��;\�Q�g��Y�)1�5�L�_��(��˰��ئǦ��v���6XTS���L8�y�d����u��U�`r���J*�cG���0k|AH������V�<�J={��ǥ/�NX
�˜�q�]:	��K�/nA!@ø��=>��C�;3;/�Z-�k^������D䃷�08�n�j�[x��iͼv�8 �su����A�����Ej6�OUV�(���}%�%g��Ŵ�m�\Z,�^j�⏥����#!��;�43���?��櫯W�3L��zɪ���,��=H��]k9�-�q� �R*'8��[f����C,�}��7i�����~WI\J�;PO_��:»��w�ۙJ���k��~ꠥw�u�&�Xa����Қ�4����B���ɒB�
�t�V���6:��&��N}�gi�:Q��G�kc������xk;{��]��j2Nḳ�M�R�(�vh�6��G���ϰ�E���p��� �4M����$4v�[��i:��:b���r����Vt�;�&m��9��i�$t8Y���z��8ן+$mߏ�J�Ӹ�o7>�ٝ�Hw��/�C��!rlӟ������ah��	�+��=p��#�Bq���i!���E�C'���a�!�6mI��ߑG�̑�GZ0�b� %:DQ<o�eW�|�8�s�A��1������N����g�q/�@ʮC������ k�&�>0+�t�Fb@]������¿De���c�j��3�ncj'ut����h	�0�cjv��C3=�MC̾������������5o��V��]sC�tsD�虞�M�	�6�p�'�u��|�A�^��r �{�x�u�@l���8`��qC�+�����S�2�9T�����.ѧ0 �i�R��JK!]K��Ӯk@ZL�;&��l3ξ��R�#X��knut$9��� ��rc$Mױ>�x��}����s�*�Od�'���q��]����v�G{LҸ����+	�;���u(��偙��R9~eY���NU��uBC�jm����R�'��)���4h�	"G�8c��"3*D(��?u���i�z�-�`U�{�o ��6`����#8�E�'���v�o�y"��L5�	��J��bI���v��}ʧx<�̒ڟ���y�:eg�Q:�AJy˲b�:���C�d#���~N���O��;Q=� �M�;I��,��y`�"���cw$�֕^�Z.޸�Cxd(`�a{�͝ Ռ5��	�]��P�T7��&�i�t�Y�+�1��0"<��̓Ɲq�7�=0��ޟ�ް#D�26��`C���a�9M���J�'Ԇ|U��%�nx�-XdM5��vћ#��z�*���Y�(�v��"�GQA>�M�y쫑-wI�1�yJ��(|���SVa!l;AC2�c[!�n�Q~]� (�(�&��%��:�5g%S��P^��N��gT���C|���'��O$ٿ�b�t���^�H��J�%��T8�`g�뺂ޝ�韺�J�&�m��{�\si*�k9��Ip�ST7�V��{��h����J�{��>$��SW���Q�E`��]�GQ���#8�d���p�}��T�\>��.
�H���t_���08��L}�^�p��%w���_	�T�ٿ�<*K̣�M����|�\q0�`>i+�LR7���gZ��\M$���kYOA�]���a�πD])��?H)���ZJ3y��S�y�q���o?٧�2��ߗa,���]��'ӄ���5�����b��2n�!̣�rP�G�����fq�<%�G���%�0����� �݄��{=�1kߑ,�Y��pT� ��/HhU���呬~d�st�b��*��	�W`ǡ!I׌H2*��ZӰ���d����Mz��C��~�w�ƃz�YgE���M��� ��R$W��f=��Z��D�R��T1���:
��h^<�P�� iZ����
,��]I��$!�Ql����;�GD	Q�ˌ"�m�wa�D����4�t�_>��.�i�*)��C����+���w�N\�?���{���c O  �L�x6��q�]j��R�o���tm�p�M��<����gG&s5[�r��e@傷/���&)�W����-V�7C��E�!-:����e��N�e����V�w�,q���L� 1�5yP��Qe�p�%�	;�Ұ"�#� *��Ȫ�E�����%���Lz:E ����%�>����S���Љ�"4n�c�\YU�P[y�t�G��&��:����s�Xl��fr"m��c�*��iw�����jm��!���7��~}n���wu[��o��ճ�]���F�Y�n򦁺[V&�{��Fwg�}�����o_�W_*��0�mճ-vlc�_����a�ҽ,,�p>'���z�,uW�έ��
`�a&F��j�jzg"1^����q�S�ɴ���ꏔ�O�uD`��V�Q���^�G^j�E��IE8�������u��wv�t�gY`[[�0e�y���I�iv�7�v�F�9�iI��h耝*��1ӝuO__��d7������F����m�{oFz{�<�� nnxk����%�M���Z(4�u��v湶z��倽7#����h�_Gaր�\���X����;N�΍'}/���^�Twkk~隟�6j�~m��[��'G��"��->��!� ���@���m4�G�� (����f����o~��Hy����8#�H|���ʙ���G��)L���v��������6�7@���۽�;�t�R�ϭ��B��3���-�I��/�^>v�P];\���;�e�b}ӹo���|���q8����d?�o��#ia���v���.)$m��r�x.�R�g2�Ui�q��P������_=�c      	   �   x�}�;�0��>E. ���];w�E�Gnmi���Tz�f~j��<޷��Z����>Ku��7��7ޝ���Xv�Nރ���ƻ�6���j�j�j�j�j�jb5��XM�&V����jb5�����������������aޓ��;���x���ެ�����������v9�Z�
�s      �      x��\�T��=��it���/�'�߼kl@�e��`��cǑ"�v²7^�����r.ӃwΙ(Q���.�{j�������
��q!ݢ���+������|ڞ����Q�c���jߴ���Q�u{ޮ���E{�߾j_��ME����
�_�z�}����˞�;"���/6_}hj[į���y3���u{�9��y��ݾ�|�b��h��������y���/G�7���x|��$\�0�����%�n˸���=�/���ȣ���$�M���6e�P
n.o�%�&)����q���WY���'��ڐ�<c��]�$�Ѳ���������O��}���4���(���;��rsᄆ�^X+{fҾE5\n�"��e���%m���*��S�֔Һ�0:���<Vt��\�9sU�?XH)t>ޠ�\H+��e����ͽhlT�$����~���S*���Q=��çү�ȳx��C�썖}��э#۾¿��жt�=�^*��P�^@p��(��+6.Tq4���q:Hr��rs��Z�������������O�L�kʇ��?#Ɲ0�m����^	L�;��:I3j�}�F����HD �B���Fa2��Z���5���|�χѡ����9~����	�ìoPXS~�"�/c���v@T(���N7�0�19j[�VI_�wtx�{�������z��h�ar��0�M9m�?(h��5���BE!�2���Ā
�@��q/r���t1�����0+�N�D�����H�R�i�Ͷ$�%mӓ���$�{������3)�����_hc��_�n#]�+B���9�	R\��1���iխ��-��իB/����Y@#lV�r�,�3�d���gn���7���ϣ�o�.��;i \�pό�ӓ7 ӽ���zN�}�����"��ǿbbt��sx2qr�+V�I^�������n"�.�P�Æ���>��e���7L�O��~���>�4_���~I�V�+�x��w����$�N�<��h%�gUBh��=��b~�tp�Ѐ;_�	�D��5�h+�*�(�Bk�P}J��<�閌�2aE=�Yh/|V���?���$@�С�C�$�!Fd�y)|V�Q��t���͟��(#�!�A]W�A��ڣzP�>�@s�`Qb�5⧱"ds4Pe�cz��]Q�8*���W=� A�ã�w:6^�b5SLe��"�1|�J�^v�U۠mD�h�pa:��%	��dbb��D(I/���~L�B��cNs�_(N���m�3~.:#����'�p��+��nt�#�����}���V�P1���[��*�5"��xF
�Y	O#R��g��kC�̴��n��D���d�ľ�_�GI�Y`�-���+_W�\���Y�kPD� 
�+`�Em�;�a(�]4���D��Ђ�T����R�l���6��E''v
%u5TDW���\���꼲�$�� �f� ��9���8�
�c��R@�M'U"=~F�Q%�[��e��r��p��n���jV=�����FJQ�N�H_��dK����i\N�Bo� �b�ϒ�zu�j1á��:��!���X��G�Ҵ�v �N��7��P��Ń�-}9�h��3ġMg������ُF����2B @�K��Oh�@�l���?]#Խ�.�bS7<���-9��1�\t��E��O� �n�-��7&ye�?E�a>]8�o��W$����׶��G�QE�P�Cl���&jWe�:�?�z���U����Gͪr`H��t}��<3�E@�T%�4.�т���Q���Ͼ-<`�>�J�b��Y���)��/	��$G�g��7����X@�hS�E�6��������P�rၶ��%��)�ؾ�>H�8���"CuO:d0�U�*"�҇��#��ek\5�S��_u�#6ۺ"rDz�c	��׈^Zn{zbF�������{��B����#kRt��9J?�D+.G�k�
�`[��,�l_	$ ��GT�#ľ<�F�w��v��^p���l��$΢ZI�80��qG��"}�_{�h���D�����xCe�L�0�]�zLa0�!2#ŉ�h��WD}�ۈHT����� ��5�~f�xj,I)�R�0�7�,���t5f�L(C�d�(0L�M���Wõ���5���z����ٰ��l��/>��@ʉ�@_ր���׸ʘ�V|e|5HY�+�K�@`�l9�L��%c�����n�A���	\�S.ii����s�y݈��� _��
�!�6b6ɲE�-4�/����J���]	d��d�V����F�Jiè��rx������XEf�y���_/h�P(K�Da�#j�����9;ר���E�Rv���ZNvٹ �U5!-3�4���s�P�u� )�*�<��M�#���̓�L���\`��v�l���uE�[ƲM>@��Ф�
�� �b�n+��� 0᪘X"ţ�+�~y/�*_�/(��*1x���7��ZԂtE�.�D� X7� 7�Hf$��B}b��z�!x �C��R���v�dʩi�d�9�!Z��{��T�0X��s������MF^U�Fb��xZ�N�,8�\)B P;�-�	�>PokZe�H����!�E�n�d%;�}:��2AMa4�Bq�>xb�Ǵ�����c�����C��J#!F2���#�|}+��!�	PI1�e��O�7!������R����g�\�Pj_߲���Cw�V��D�i}7,)z�!��E`�"���e݊E����x�Ĕ$rCZi���\����/X�g�6ѿ��aVD,����&��*���h@�j9���x�b��t���%�;N:-K���Gy��Y4��p��m>& ����k�$cg��t�Q�2�J@Zp �����q�3�x����eH��P�/TU`��g�����j����ח!���%�Q\VD��q��$���D�U\�m�A�����R~��E�D�Oq�!3�>�e"�Y�a�>$���YT_9�I9IQvI�3=#WD��%��	C�4;�W��MwX��z�D�3�y��y�?D���q���hIe9qM�38ď|�CK�k<��Ԡ�!&v`ª��?���R~�P�>Ɩ^U�s�"T]� �Yæ����a�Ƹ���Z��i>��J�41��d��e��1a�I��1W2�@C�qY5()u�\�v
�	%�>�	��W�܊�e����� nNu�d`�kЍxT��zdCuI��Za��$� �$5��=��d<��e{n�8���	���y�pܳ� c��Ci(�K��C~�W��u�#�[{�0M�U�%f���c��\���f��6����Z03@Qd��;xY0�}fD�+�1&��t��.���(�E��\���Ԃ���',Q��v�/���XuWL�=7���������ΖIT�W��S����5d.���g����O��n��bY*S�|�s).�?���7O��@����c��7m�];Z����9�"���l�)���1�UB��h�&J!��`;���I�A�;d�|J��`��.��:�.��u��)�W��wL��H��Q��"�Y2ڴ�W�	�@fA���L�����{����?xANI"
DԶ�"�O����ѻ�١�B��	jZ#��ZT��b')Ǧw�*o���"0Zbk�3�f���m�����l�c"�[ �[�\8؜���r��T�J�s�)���CN6)��4VN���3ؔ�ܶvf5��R���0��/Iꤱ�J�=a�(ň��|�7�������yѼQ��"ݤY�TlJ�85�|��8i`Hy_�!U�]�r�̐�;�ľC�V�mg�Pk�>ģBE�oT�����4�
���Ƀ:�T|4�#�sF��QdHd��nDdž��Y��Y�9 +�3i�dM��$U�b�(�B�]��,C!̳�q@U��qPo�8��bt��p@U�o�)P3�s���3g- *���@�pg�X����e� t����� ]��'"��n���^BiU�8� :9��LΆ�ށ�F@�C��3�+f����QN�4  r  S��Ic`*��x�*&�+I��Ԣ&O@orI	��FȦ�팘�Ѽq�7���l�"�V����M�/bz�?�l���l!�&������3P+�N�!�Z�n�W�(j���w�*8��eS�u��Z�Mu[I�ˑ�Iw�4��5B��aFg.4:�����e����u���0�1��ܸ3�C���u�R�6��FQ�r�&�شЬ�Nk��bOnnŘԓ|�յ�������kc�׊4l#{k�؄Ի!��f��@l�M���yK3��y���S��tK3��t;��I��@�޶;��l�0�	jy�>[�������k��(�Z��4�]wq��W�>��[���y�P@W���R�C ��
V�V(���{�����I�P@S��y��(�~|��ڟ�����qqN�8��O�3pN�P����������lhSڟ�����;k�?�s��)����'@���O�৷?��gg�?�<�v�/IÇ*�?e����b�S���'��!Ӂ��'�4=c�������$hf�x۟����?����)	:H����2-���DS����|n�`­O��k}��>A�����en��'K!Ŀ��g      �      x�����ݶ���{���O�NIE�$H�ľ����;��tuW�c�;q�vN�Iwuu�lY�lY�-,���� @b�5I�Pv�Ҫd*��p��x�b`@�rQ����to:�y�������������ۯ�����ۯo_ܾzt�O���?|s����ۗ���?qѝ�t��/���27jX,��������͇�y�#��������<��e�#R]ԴC�����ŗ�߿�����(�����ۯn_��٣ۏn�ے^�o�x�?��'j��C��?��s|����E�*������o��}�����ߡz^dE�'z��c,���"m��?��~��,��7�������G�d����I�_f���t�o��}e���*y���߰���{x�'pe�~�t�5Ԯ~�����V���vBi�\1hC/�W������|e_�l~�>�O� ��=Q�I���Յ���~�����d�>w�pS||��vK�����^ͿZ�7������w=��.��(�D�B���"��o~[lc���l���6fK�����c���1�s����o2
�C��w��[o>D�ݵ*7l�J+ĵ��2��g�.zߥ�}~b�t=�v���;��Uk��Wm�fߝ�����=�5����=����u,�VҲD���-��=6-g�MҪbA�n����K��۷����wk/������M�փ�>�c��T�x�٫����qe;H�'}Y�w����P!�/m��{�x'?��fU�e�(u�=y����
>�������;{y�WW�i�2�����F�_!�����X���i?�}̑�+�/xJ�2v-�Κ�����i�qT�f�1�x��P��|��h��7Y2���Q:������"�~��'��߽��b����=V�k,��	�*2-a�pfg�P��aW[`Cq��������?~��K?6����s��5�Ó��_�����]��1�>��So`�?����k~�����P�����ٮ���a�f�@G-�G5�y/l���c�#7���Q�jt�hB�~T���������ο��c���x�`Nt�w�}������Q鋍r��:L��o{����;�Q��] ��`�
��`��]ض5���i�P(fmLi!n�Ԙ^C!����H���u4��|�������=�~^_��u�öI�yׇ9��f��o��?�Y@���:̱i�����ek��6l;�����>��7���|�Bm��Ol{ױ�jDхU���?(��;"������e_�8ļt��'�܅�Xk����� tݎOo�����}���?�?C�}��?À��f��p�����z��_����g�8���/�MZ-��o�X�=���S��_'��}�Tʀiq��Yoǳe?�}�i%�A'�w���*����fKa0cU��ܟ0���w�by��2/i&:�2�B�R���Y�`��W}�h��g�X�a~?����Q˾I���W�����J�ơ�_���~�7�y�.�{�7/lc����ra"���b��������'8���FEY��6���\�8ľa�����o9ѣ	�28].�k�`��!��2t������o����x�1o6T������C�d[�������5:�O�|�0�o��������,��=�s��?����3�g,���Է���7��q���7�6��}o����C}�hqSSwMЋ���5m��ݾk
{�mZZ�{�'�r�����2j���r��ni�Vj���F�/�d1W��Z����k�n������m<�S�}s�����������K���21������%�}�v#�7wd<\��9�xk�(a��OEq�+����#����O��ѓ�r���癅Mn�����<\��"��65R
�K�i��"E���Wo��߉ZJ�o��������1Y��.�PB��K����^���,]�U^R��:��k&�gn���1'��Y;�ĵx��vQ)|-!�R�M��9}�O�����6�;�P�?2�J��+v�~�������b�n�,��.��3s:�*x������~��w�á�� �V�^ci��F����~��W�7��k�	��k���Cܬ>�nqe����џ1�uV|mCq�<gѡǐ���m�����W����=����c�0��/|�YS�7��T(a�.�[�~X��st�G���6�2R'ߺג�֮z�Q���.̚����q�K��p�]Ox_r'8��X̘=�k��We=�����n	nr8�?���,�����z��-2˃\3�>�#�֎�U(ۿ��G�)��ܠ�1!"���%�݄Y~?�_=���3�A�C}d��4b��hFm�M�V�/��}�� �\\����o>�jO���u���ٯg��������z7~�G�uwo�j��#�r��<����]�����#7������w?�~�������8�#��}��l�ܳ�~ϔ�U7\��a�x�;c"��d�$w���h#G��,���7����a�΁8{�����6J��O���R���e��9l������\vq�g.&��2�_0Wygj���F��f�;?ܙ�H��/��J�nh�Cl�gtc%|V����<���I����'z��Q��
�З��|xW��_���]�Q|�ғ�1g��>r���1�����A:#�²�Q��eNΈ�
�l^�&�����*��[�d]Q��$_�ߙ��_z�z������08����c2'�/��y��,�� +�cV���M�eI9�+a�r��Y9�+k�r��,9��/QN��E�D,���aW[r"�WQN�/���D�����o��ʈ��2�;r�gdD=�ی��9��C�Kȇ�D�Бӕ�!W��Cib�!W��Ci!��!W��C��9%"���}'��T���e�eC�
Q�)��/BM\�3�5�@����u��փ�[U����[9��g#'��d�Ǯ��}�w���)�u����,�զ��Yr��}?=9
�G좶1�E%�qD{�ʲboĔ�,�$�d��)��22)O�u�Z	�CcB�Ϗ\��G�}�~K�g���P�-,v9��T"n���9j�h��H�o��+^z�c�����y��(=����DI�Jj�>ə��9J��'���"� 9�;�}BjF6�l�)L@j��*H�N���3��Qb���3���,V���̱� -#[PR��c��I�cσbM�{��R2����V������U����b��MQ�}4yj>Y��"b״�Q�!ɚ0�g�����J�{�'c왶=j��ᎥR�p�0\��o�H����qS2����rğ���Lf�U����&v�ɥ��nd�j���8b�Y�Y�a������/��k�
����p���}?<�]���L읶	j���o��ŗ���^_�}0��msZ��b�V!i���>9b�]X�����\�M���5l��ѶC��3�FgXX�3��0\L얶5j=fȁC��_���mC�z�����%4\����2Ŏh[����h�εi.�_�1v��=��D]��#m��z�#c�����d��
z����{�m�Z�{%�
F��]5��eR���ZJ죶i꾐��Q�$�d�L������C���%��k������.cޤbߵ-V�wdg8��m������;!w6$]h��8��4���,�%�ƪ���R�n���|򿺖_R=������jl+���V�g���IsM�>����N�Kl�9�~ew9�,�Y0��y�+�nE�nٯ��>�u�&:X`'��M�6:�'��*�+3��)��.6.�̴��z������=����Iuk��}nPi5 c��MiO���ӊ��ق�$0�aM��ޯ��9t6v�uU�.�{��9`�}kX׏�a�_�9_r�{��{��I�agۣ��G}�?��폸�����^fQ��"O���2��4�ɫz�࠸۱|8�m���|X�BY�?�U�W�%R��䪙ԲK��7�a�k�ϋG ��k�r1!�"�_�6�X��_��]־�g�[_s�{�঵�i������68��]2�bf�<��Z�i=7ߨuw&+cu��    �[,xm��_�k����������B�[se�l��+ �1I����'Jv������͘������l=SƼ���t�ˠt��n!	��N욝_l'�9+��
��� @xV��57�`c'?��1x���.���*���ܼ��8�H�Z�Y\���/k���+`4�]������:&zB�t��M�<�8�k����W���T�^���m�лf���c�.�%�1 ݎ<A����;r^S���1*�=���]��f�6�P�ۏ�I��z��u{%Ij>P�6�ak^;��o��B��K��Զd'/�ʆ�:�cz��_E�}͈�}l^�v[:OCnn��ߵ��KZN�l�M�����9������n�n4)�ȜLX,k��2܍�hD���Y���{e�s���d�b��>T�	LFZ?{ Z_.��3�sN���ŉ}B)��	�(�7����V���nǝ9|�9��?���"{�^g�.+/��;y�W��E��^~��ߖ1�"]{߮�,��"��v]>����"ns�"NRMG�*����b����5�Z�t��\įJ:yc.[��V!��/髎NҖ�hi���NЌ�di���Nڂ�x�ҁ�%Lm�X�����,��[ ��������᫈n[�":��j���Z�QBWGΥt$�J��V��td�B��]/�#\NGG\�щ;��0~�[6>en����Ο���z��\�{v�o�,<�Т;��ECvhӦ%;�Ԩ);��r�/[ަ�������tyT	���P�;����(�v$<�7Ō��"NAA���3����r��"�0����B���I�W9gA�՜MQD��:��I��Nq�@�Wi��{ �m��DGag6	
<YJ�w�(%��~�y�r$#�<�ɏ"OY~�����v#�'J��3+AN��BV�皘��y��<7���2OrW�gʕPy��<��I�'�Q��#�ˏ*�'���3�'��$��Δ|B�I�*��Wق�N���;��C���qwn�b2�N��;_�ObW���ڝ�</�$sUx汩���<ܪx���;��EF��BVy�:�
�;YΪ���*m'ɫ�3�E���,cUv���N�Mvn�C������̗�U:O���s;ϝ�{�՞��<��>I���mΩ^�I~�~n�Z(�Q�������G%舩�2zPң4{�
Y(�Q����PЧ(MB�j�(��
Q2D�ׇ�*,%��:�\Aq(y��䶖��1e(h��0���PrEe�$FU�;�Յ,��6�eDihR��@��� �⇔J��(���ᇌT���݅/ՊQ�`4[�	G���#���G�/��f�#W�j�@r��A�2�U9$G��H<4�"9�(�FrP�
o6�Ng�wj�Jr�Y*��pK�d�$���q:ɕ���I��ǄR�=�PrС}F�4ʧ��4�)�R��T�g_�VrE�-�J��M,��m�Yr�f�%��rK��K'�vh�]r�]z�`Z�~j�`r�9d���S�cr,�I&byH�I�	*5�%��oE�'��#�{�G��b�epŅb��e�����N�"�(����
���#:{m�׉�hh*$��V�rt�X���sW����-�>	�
B�~�˳�?�td.֦%܄�d>�I�')B���Q=2���S��`,�hF��$(� h�8Jz<*I=^�ѯ�B��x���<~�x��~�у����q?�]�1ތ8U"�s�s���G�J#~~��U�F�����~��_�_����^xeo>Dl����O�:^��=���@E�����\Xa��)l�lV@�8n\��>�D<������� ����h�Q����qX�xvAM�V�C�׳Y{
�������.Tm�8�v�h��W�6��*��rE���IV���"���I*l��v;A��%n�MUd+�H�[7Ry�7s�� ����� �n[�e�A]��]����.�1<d�`&N_R����5ݗtr�]�/��C� �+-�փ!�d9\��&��B�6�ك��*H��G����fc�x���U��o�wm���I��l���k8�J�tQ�ʉ"n�M�K�fY��(mn�usqpدa˜BM,�҆��ɒm�����]
[�����^wuu�V�.*�S�j������N�qmii�#�E���O|��)�����`��{��v`��={�_I��}y_�"�a��V��}�Q_.�K&z���gnS;xv�9��e¡�]�=s�Whn���~�A�u7��9{ێRk���[U��k?g���n�s�؍���l���t:�}��Cv�X�_X��C�>fG�/m���/�֘}_G��
�1�`�t���wF
����[��K9� �K� 8���|lf��s�m3�m��o	V>q�����rmgz>(I53�]�� ?��{f��_�\�n�?;�.�*��m�?������JX�Y6U�wx��:\�c�>*LW:�O�r��R:�����E��rF+�7�M~�͊�sb7������M�V��2��|{SC�1SC�ٻɈ�m(���ލ���eK�3���#���:�]CF�"x�,�`\q��+��j\�$4$Л�'�7a�J {Ѱ"��%2.�7���F,lA�8�p�U���&����5�.t����0�Up�pB�7׻G��M��0t��:)�C��m�&�ah8��j0�MP�'_�ax��6��u�0��m�	yE��7���#!�.Ԭr�0��Fp�>���x�%��P`�ߤ="�v�%	�CG��\'�ax����_�MAƟ<q�+��a�mg���0<��u���>�=O���*`��� �������;`�G%� =��'C�+��5�7|8I]�E�,y�����^����^�*�˽H��w{��K]�E� }�����^dq��#��g-�]XȺ6n�ɻ6��ɹ6 Ȼ6� �um� ���>���[�� �(|m �&�����z���� �'�K���� ���ʀ��V-o@*\���[��@ג� ط�&`� 2���zH��ޯ(��b��te1u7������U} S�-~S�J��>r��=}��-���������`�0�R��7y�Ob�S+�!wn��!}��oMT��B0&	)�S^���t� �P@�_��ؾ�^,`x+� 56�o����V!9�s�;��^��s@��ŝ^$����.� �h�,J'�o����m��2��7{�#��8��ɟ��E���r%�0v-nD"Y���d��>$��F�!>ڌ��UR4B�f�{o�$-y�Za����H�-��G���"�0���(�Ğ�OkU=�IRKj���NF�"���4����WO�� �ۜ��Ͷ�*|W��Q��"X���El�����!�������_[�x� b�ۺXb�&�u�eb�ۺ�G�os[��2v����XJ]�0t4�����N��wv�����.2�vwv�?�3]&ߴ�\f	Sc�e27p\&x�7\;э���W�v�djq�eb�f�$R^ˤ����Y�i�L���h����>��.�6�`b'���2�Q�&�����,��,ih�L���`�e�v���O�앉��+�H�+[*���IV����׭��I�[+�>��U&��U&մrU&}jc�K���I�쥝�.���p����K@J��U����:�`3�2Q�{ykHry�(�cc�(1RZ2�&I-�����ܥ��#����zd)���#K�-�YB���q�&A��bq������U�/��,}��U-hC;CN6���'K0-Lه��f؃�[e�B�t6�H
��"� ���0D y�4�C |�4�C |9�`��BZ>O�K��W!+/��Gz�2)��F~`R����x`M�D<�l�Y<��"o�0L�I�����Q�)��i���;�}��;��@e��@���v3�gہ�'�Q��6r�� 8�ȧ�Vm3�(B�K�ߋ�"�:�"�7J�" f$M ��=���- ]�,�t��*)?����������    EB��4��2�Tr�^2�	� ��v�<%�iuH��Y��Gd^�O�Z,�H�d�U-���73����U��uL�u3��Y�JCU���Y�������n{�_R�sN4���p��C���+A�[�p���C��Ψ�/;��:[v�U-��N��}��m��0�K�T�}����ϻ�w?m~�!�.BF`}vU��c���uؼ�,��G�a��w?�\s��Ƽ8wxm=5�n�n3yyJ��L�[�{�Z|���t�Q��|7]�����;�q�c!T�/#�
�<;��ևZo~��ݦ�K�4��D�ĉ�]~�Ɇg�;�C-�q�D|p'3{���̃��e����9O��M�ٽ���M�=��r����7��\��a�ϱ��(�7�xI��i�U8�1�mXA%�ݱLڒ?[����4k��[���G�����1ā��CM��C(%o��wPR�1��o`5�Ǿ7=s�P��i����e]t��zʿ���&�G�В&M��yt��8oi\%�Ie��&�0}��������/��b������e��uxX�����]���>4���+����^F
}{���aK���淄ʌ3ӟH�z���M���ԇ�]Ծs�~/{�>p� ��>���4s��.w�>��0�,f�?|�?��0�.Y�w^��bm��/r��Z�	#���Nf�����'���&��>4;���6�#�������S��>wqi:���K�)z�'M���vڅ]�Тǰ1���M�t��CK�$��ב3�yGv�YC%�G�����R��B�}z�/.��mS�k>oSj?�o����V(�&�}zG=��c�8vKx��􏻄ԟϨO����3S�I�՞��Z{S�m����z��D�2�{��W�Wj���8�V�I���)m nhD��E.u�̝�/�+�C�����>j���e����Φ�/?����Om��=�@c�Q���&9���vX��M��}�Iw��: �hG5@i��������D۬"�<cl���$�a�ߋ>B�R)�M׼��{�bĝt´:��"�l)z(��:䝹w>��P	�2�P��K��`/���wmAx�Re˞~wo�>B���@����S���9\��U��/mO�&P���.�;�Y+u�<�iTr��!�l�>Cebæ�r�tF���{i�`��(&1��%q|\Iggߵ���H���.ݡ�,� �>r�e��u�իz;r�����rڡ���1���	�F�����"��])��ߤ��5������H���Fȸ]�8ȯ�7��ɷ��<��ӏ� :l�U�'���
�=�q�.Z��(��,�������p���!����7�|��DiWp˴�GSp���=`�3��8
hl�"�fW���Ю�Y��̦&����u-�|V�N� Fg�3Y��#7�����~�'��s'nТ7iܠF�m��r[缽��
�=�^���+��̧��r;.���~Y'�cg�~���V_�/��𱋆�Q.q�H�-��G�~��e�hYMf�U5hѩ:����������E_�j�qТ�����M]�Q@4�u� ���4����Ao�<m�:O��W����+ �F�������+�C;�
���>������-���m`�l�};�gЅ�����y���3�b.π��gc�&�lm�2f1�	Є�-rx~�(���3��ݜQ�[1sFAM��nl�":9?�L�:L��HLX��IL ��&����������R�i�	@'Y�	 gY�	 ��r@��6U�X=�Ϸ��MPa3e ���k�.��F��<m�\�d`[['�1�d�D��l���"i.b�S��\p��\`��\d��>�d�3NF��3I��19=��@iz�֕7��<Cq�A��#�D\#�"�"gh\m��>B�:nN�&����XD�*$M=}�6���U��h#tܿ�ꃴnJ�'i=t�j�o;��3�x�������~
�<=�^v�����5��+�鲍� ��������������8��5ʘBC7��qX��y�ع*��b��I��v�t?��s����T��5N|��nr߻E�;�g[�9o��</�������u�u	Y�<Po1>����gʓ�,Xr���R�'	';��N܁���³p��6^x��*/<t+/<�f]z���c:��}}�*:{�+�O��@��� ȶL�t��Ȁ8����C*����d@��C�3��@0�ܟ��U��1b�*��[�����BС��z�yQ�Ȑǰ/1�?������:T���J�i�<�5Z+u��6��]7?�n'�Y�@�F�jƝ�f����� ���&�Z�G5i^\9�����́w֕��%Pj��sZ�5X~{�����
#$��-AՎ i��a��2oO^���?��''�l�Jws7�	�۟�s�����%��7y�U`[�tf�����.��&5��tW� K�s	mb}��¨�YO�ŌY!�z�ٍ@��Ow��-�BB6Kn
��B�B%��/��s����̎_GO�`;���/"�-2�ί�}�E�f|���n�R�5ksO�oן.>Ҳy�3�t�w��vƣ.��3u]Ѣ.������8��D��p���Bn^�l�Ipc(��ʃ8�A��z�H�����{��'<����[iLjV��1���L� ��}��	ϩ�N�5�/�I��U�E|�������w?�~���?�x"w�ND�>��D��a������٤����3�2'f>W�kCa9t����s�>=���q���u94)��;d2̥C&%d�2a&��̖�{�<c�.��_O|�샏o��>�W��(�9��g�7�h�������mr:*S(]-�o��1s EC�;T��sg��,��4f��,�pd���͋9�E|a��1l��k ȕ������E�'6*����������������L��Vm�٪���,`�n�̕F�����<-B�&Xa���hVe� �f'`2��y�l��_�B���m�ޕ.�k�>�6��:}���~ř_�P�@�o,�����YXS�g�\�SXac*��}�W7Y���Х�5j��H���M�����I��r����0�������{�!�⦏_g���梶�%����.�%�Z�[G�/z[����mZ�'�*{�����3v}g�l�0�͟�v��v��~ڒ��:�o��zd���l�s�u�y�l�7�8�w�5X����{L�������V֕��t��j�ĎN��J_��J��ֳ�������{ԛ�pU}��#˓�3r|�Sc���h��
̚䩘�7��Z�a��l��c��i�tO'�g�]��4�@�Ύgol�.9�GV!zuh�}�+�%��nC?cɘ���j�~?T���7"��+�7#t̡�3fS�笁�ʖqP���t2Sf��˷G�-K�1>��|��t���ʌ�<D�&�'��#6k �/Hs�lD��!�A��$q=��f�S��h@�����G?�ݽV7�Cl�ژ;��?$�E������ٻ`���΂3�u��T�9?�l�g[�|s������'|�|X�G�c����'�'�C����΄�`u�[��_�&�(�/ �afF?g�������Kٱ�z�wV	�Q��vU�k�������7c����[:�aqx�_�����N4ZA���2m��~脫��qa]��/Zx�ƃ��4oh����(y�|I�7����Sl���z�rIL����4���;�������l��{]�G�������v��t8��v:-��/%����m��_Ծo���?���~�V=\Tfa}^���x�K��~)w;$���)�����ےP��k�L�A�*�_��y8��b���P����I>]
^�g�Ja8���<����gRܡ��f0�꾟l���	���⃻agF_�z:��/��iͻ�N[���n�O]ó��O�Xj���{�R��g��br���h<���l��9W��wOw�����2G(��΃��&�Z��A�C�F��|�ƳP�2���Ac����P    !����q3Y��/sŞz]!���_{����(F�Zgwu�P�:#�&t�hJ�~�t��fP�{Ƈ�-7��o��44�����-7��V�� >��C�o�m7 �·݀����Ƃa&%z����m7�떷ݠ���m7(bX���\�"u�J��:w��>�!���8{H�;do�]����IF���t@�[^�����X0n畻L@.�ɞ��R�q�E�Ku��/R��6\�/��r��8��W�.t��`k���E�
K�5�.�m0���"PU��%[��\�*
�շr^�z��,��/5������Y@ƕ/M.f�S��Y@�/�.fY��Y,����	��!y=���/K�"|σQ���&E\}U }��Z��M0�>Y��=V��n�A��M0`On�w��	إ�M0�+cɛ`�T�7���[�p/u`C��`PLr���ʏ�a�6�o�A�؍0�Ͳ7� �������Sō0���7 �6n�AA}�a ���"�v7� o��Z��$q/ؓ�0��R�� ��� �%i��ჷ�X,���� c��Ç�1�+�;b ��w� ���� uG`��1��;b��d�r��#�E��u� )!yG�J��`��1���w� ;4�#e�k] ��uv�����յ.��k] V-�u���^���S�w��CB0oj�dD9�t�M.�U� �.�.w}��I�\�����at�����������exW����}y[l���-6@S�-6s+[l��V���{�+l�AP�l������g���1�Q={��KK>����I��ަ?T���]�,]�5ԯ���d���"���9�3,s��m��p��Ɔ�.W�hUC\^.j���p-��QCP���~��؀ֱ)�cRP�\б%uZ�f6����G�&�iCAӖ!�lCAٖ�Q�o��1�ے�R��Un	�N�jԺ鰑)�u=j�2����D��Z����sK�"*7У�-�!��Q㖠kn�F�[�c�un G�[�\�Tnk��-�9�Z7���-y`	��Q閰�tn�G�[�S����rK
�Ը���q˾�)�pQ��D�m�G}[�>��m G}ۦ��m�Gu[�ȫ�m;�j� �ڶ�9��m Ge[�׵�,�k-�ڒ�P���m�Z�qׄ�D:�V/#�(���G�s`E�\ªЁt	�FFg�s��m��2:P3]΋���Dt�Lߡ�(�Kb���t��(�K�DHF|��%x)1�QL�5�j)�QJ��%�t`G!]�G�et`G]���t��D1]��b:�t�et�G]��W�� �2� !�<��$�7.QB��-:ࣀ.����PB�ѥ}�JDj��k��:@��.�J���/�˖�'�s F�\>�ρ�s��_'�6J��	�PQ8�-Kes($���uZ�h�(�ۤd$s(!J���i��Q8�0O�� ���,���BT�eaR�d�(��4�J����޵r9�rټR%�6���QH*��Tn�C���咧�ʁ�r麬J.j���S�Y��Q4w_��hN�&� ���>��9��h.�j�s@�K� �ҹ$?!"�<
�ʨ��et��
�逎b�]-�8J�p���(�����:���u��A^��/�Ev G�]ڎ%�v�G�]�/Y!�����(�KjX^v���pWm�+���ڠ��4L���J�Y��6����7U�Q՗�/Wi���ھ{+��EQ�!��>��ҡZF�|T�%x����/�f�5�G�_Z�"�?�W�_�I������Ұ���U���0\���ﯚ�t1U��zU���G�T^S6��K�8�۱eC�s[6���l<v^Φ��	���-��6At��ZR޶�6AΦ���M�c3�6Ѝ�Mh��Mh��MxK��m��d�keC��P�jf��nh�~�ʨ�Qȣ�Q���Q���Q�s3�6З�Fm� ����ܨ�hI�6 �vFm�A�v��SR�2�vVm(�D��q�����-P�eEx+k[ ?ja���ȲͲ�C���-����eˈۖY�Z��8D���w\���cP��Hv�CD���&(�r�m���@��e5�e�ŭ�@�RH���R����b�fVn( b;�˗8VHi����}^C7�!�kc�:2&�n #���8�*�� �BkQ�	��#z4v�U����$��:H��M���n,�ʴ�`ST��AL$��F�(o�F�i��F�$k�F�,��F����dʆD|�HS��X�n��Fx��ꍅA��\�T'\��Q��L����L�o�΍]�X��6l�PuE�o$���o,C�s~#����w�дY�Dm�V�f�cе)�c���u�6K5����傎��,y
�m&HB�f�s�%�s"7�^�ntw�#Wu[����W�Y��)"o��^�,��A�-��Q�.�\#/h��I�0��Y�1��E�2<
��%l���Ʊ�^�5��A�6��Q�7�D��8����s�s�8�y�8p�41��PHJf���ɺ��ɽ��IC��c+9�M+9ҧ*9"�V6r�/m|��F6�����:'9�]-`%GP�K�'��%����jҦKU�RM�쮩�F�C8�SwM5ɋ�=�<��I^TM�
7UOL��S�j���߲e��&�wUgx���I�e�)���j�G�۪�4�U�4����o.q_5�s��:�K]X�cu֓%n��	Pl�;��:Z#����mɢ5�m���h������>�E�Z�3t(,�����Z#Do�����ɡ���ELmqJPm{��*fn��m����bv"t�����M�N��&f'{�.f��51;AӁ�}�y��)gW�f����S[�?�4�,e
"�M)�2_4����R�����)"�E	H��c:BW�|	UA�[�s�/��A�)�R�Kv/�]I��+�.):_���`���z�/�FL�K�ľ�7'!�e��ޗ�%�X��\�e	6V��6��vZk�ʉ	TAO�w���e���x-v/4q}���FGL���f`E�?���CI�	�C�6��rb����M�O!DQ�HC�o�&�lכz��������s�>F	I1���4�I��Y ���b�!�^�����th���Z�>%�ޯ��b��xK�P��)���K��vos��E�,c	��ͷ�S�l�{�����銉V��2GW)�I���2'Kh�Y@�ś�?�.&u��]�|^_L��0���T�m�f�>�1&o�����#�2fIs4��K���Dw�]�N�Jcq�Э�ĩ莙?�i�1�:Zd�TQ�1K�Of^R�Ҙ�!�e�֘Ō�1s��E��,�D���<U�7&{�ޙ�1�VHq�R�h��y)��c��ͱ����By�ƣK6�?*��D��6ޠ+����x��L���VqLv���y�I�z�1K��xS+�c�Ǡ;V���P �o�ٸ����:-2K��yp���Q�G&wzd���!�I&	��͛�V'�>uA�l�:��Q�S&]��nD�,A�2{T���.���j���vy��"*f�0��*��Q�g&�=���e3K�+�Y��97_���%(��Ȋ7kg��N����No�YDE�TPQoJ��S����z;A݊)�YN�՛!GHc�2�����2jk�1����Dt�,���&(Q^��)(�GK�?�4��^^��������:�ts)�U����R8pY%/!v	�{���5�{ O]C�=�ފ���ͼ�����j� d�G���{������&��MH��C���詅	�sp�+ۯq�#|if�<������֐�e��|,����#qh��G��Ȕ�p�ҕ�%L-l�H�[�򑼴1�{�9���\g� s@���v��ѣ/�J�v��hg�<R'�!zs�#�yM��P-�!|
⚍Y�y��s�>�q�>�I;�
B�m�y������অ�K��f�J��ݰ����ď����ŏxsie�G�7��ް����Џ�,�Ǝ~(�O����������}KK?�0NV������L�6�~�N�L���eM��\�M�F\    !�Z���잓!��B� .h���սG7��K�<-�(���(���\��Q���M� `�&c�H�no��r�F&���MY��K�)j���P#k�H���$����&��.�MQt��MY�ja�H�nk��2�v&���L��$l�I����h�ԩ�I"�s;�D� X��#�r%С���U@�:Wi��0��[��2��?�t'n;�N�<�ȫ���K�.�]���j�,t8{� Nޓ݇��r�1��p�Uy�y{����{׹�s���p���/{��=�S8e/E�y��=��"p� �1��+ݻ�����m�"�A$� 3N��1";�%�D�2��`��%���a�ʖ�"�o`�r�]P�:j͂HnbD��Y��ѓی%��w���8+�r�QlsY�1i��P������0:���62(�',�$˙�r�;���1d�4�e��>�?�1dM��|��n�sui�k�T�t�чTn��AU�	h�C��H�=�n�P��"��
�{��m�\�>��7Ϝ`�f���ͲY���?ϔ4��[�BYB�/���.h	�cI�|jK��x����[#(��X���)"��a�V)�9��^%N)b�����|ȟ�Gƫ����/�2�Ӹ���f���W-�K�l|M2��f�kK��N�ga����-[\1)�4�ks�˜�߿���K^�kJ��VAZ�U��%�.�Y�}�r�+����HP�f-�r�i��M�{�Sf������������"3�q9eT���ñJ	U|߇E�Et�~�?�|��[_S��l�1��6�F�Ep����6��W
7���)��->*7��՜�->>�������V����'ٯ����?)��^�)����8_MN��M��k�)�^l��P��YC�o�^�gN�ܫr�u�wD�Xxe�(�ʥ���*y�~�$6�S%���*�F�O�89?U�d���x�C��8x���f�x)mr��Q��� �nݛ;Iaيh$��hl�1d���R���� �ѱ�l�ا����Vٻ9��G<Ҳ[<sO�r.�_\t���?D,�`���E��y��r��@0	�@Yqc�êKi{������L�V}w�C���f��%�n���!`l��C�i��C�tj_���> v����K��������7�t�&�(P��9P�tc�&lUwc��dN�L�:��nvv��xv19`X{r��xr��	k�,���"��̢���ԞU$��YE���gYB㳊,#�UL�_�<��BDO*���"����8�MO(��Y���F��Z�$<����&.�$N� �񼠈�7��`�n���@b���x�dݹ@B��j�m��y@�m�9@x9���S����� 44�1���l�����K�g�D���nv��vg��ow��x�O�d��x�O�d��x�O�dt��9�7W�����3}��@�3}��3}���M�3},!���IL��|��8�Gp��|�;�G��Y>2���;59{F���3����3�Ϟm%'Ϝ����첉>mF�[8m�r�6#��i32���f,��i3��6cO��?��cO����������8UFZ<UVΣd��O��O���m�)2r�)�x'w��1P�xz��EW�#U��DSilM����V�Y��;kw��M��5�C0�&�ں��1XW��TiXM�	�Ձ��ڦ��)�T�o��95���95�K0�v�T�r����q�{ڈ�<��kzSn?M�nl?�B�`?�^����4iC0�����j��1XM��I�`�r� ��R�ɃDř�w�-~���)�"�ۦ<!��K�i�#�Ka�B��IԓLK��º�1c��6���;rYa�1�uC��J��kP?|����1�]�n�5sP	I�ԍ��(�I��p~D�n�(�H1׊=�����h=������U��G���>j<yF 3Yx�'���)�yXD&>��CԲA��k�ĺ�x`��}o+�g&��x_�.�靻ti�L��c�lO�r'�&�߿���Etv��c?����o|���(O)l��C�}�d��Pȸ/�T;�uD񖦆�K�[��T�>�R�4�1O�$T�=5E���?v����,>W�!6��;�����������Z��n� Ż�8.�S7sT�݋>��S7K≁g�a��j�������8�dq����u�Q�������y�-��HI�o���et�7TF�*�����H��m'Cry�9m����tp��mں׳�|I�5j���A�D��M@tw)}���/���˳o��]������ն�K,o ��T���21�n*����tرր7P�J�X�,ac9�7�ɾ��=�]bv�&cK��X���0Y��lȊ�ݣ�Ƣ��ocK�5��eԚ�X����r��1�%N�g-q�;�hi�?�8����Q}�Q���o.MH�r' !v�h�>�#?m��7X��x�"�/�ݻ�/AW�@.�K+�l����W�i\�����`�i=M�����ֆn����@��Gj�c��k��tӹ�5��Em��H����Z�ʪ�5m�ס�N��P��:���	����,���
/	�=��o��`軀7��H�A�>q!aU����l�����[ˣM>��g�ʐ����	�ld��}��쁞|d����z�g�gO^����>E�z��]|X�<��	�Q���}�Bjc{;ʎ�do����P���/aƤS�y ����i�qk"\��ǎ�=���=4� ϲ=�^Œ�BI筱�8���d�E��zpvi�v�k7�-T�j�w�px�h��C�h �[R�ك�`��������xR�;5�����[ڝ����@p^Ά3����E.��}Z6�B�>AS�>Aբ�>A샳����9* 8T"e>C
�;B
�$x���ptIZ�	��}:�j>���%��.r�O��!%i�����Hslu�WK�f(
1B�N
���t!Pe��B�/�N��U@�i�N�wt�P�g;�nj�r|��I�������-c~з���6�%}� 4R��M��@�-� ^.�|:_kAxr;� �6:k�u3�5�}+�5�C�5���� )r�
@����kK�� ׯ��Jd�P��d�b����Y�.`��I}6��,(6\��y!��8������,@
�/�ƶ��8�kb���B`�]�װ0ٞ�/'��a�)���������I�+�J�R�(��q��sSP(�]!kxh��@�0�ֺ����#�ס�o毫�g����9+�hܓ�_����`���ѻ�w?�~�����Rq��W��wش!��8,Fҷ��sa�H�Q�w;q��w�:��`+���T�����-����.L�W�&e�8���=$�a^��Z�2q��:�jg�Ǐ��v'��%
�"t���B3<`���~+*;�w�--�cS�JM����`v:7�o]!�=�=��dv���=P�(:zb�|t��#x)�`����g�6��`b�0��c�1d0�WXZz�;�Qz���쭀�H�}�}ǭ� q���O�N&���];��NF������cHz��y�����>�>�|�.!��Z�������N����:�Kx��e��%!����"�v��_�{݉�%<�*���s��,L.�����w?�~�/��/�*Ĝw*����:}W�!��~���]9��mƌW���S�ITu��u������Z���Z��7�x�_��\ι�z��S��ʂ��H�r7~���5o��2]�Ȭ~�+�~�#�~���� .�Uas����YWuQ�
'\�?&γ�0��)�B����i��>Z��B�@�l�N����w����,V��j�\u`3m�>L�M!����o�K"�up	2�54z��bl�c���C�ُ��W�*/o�Uw/��ڮ�,��K��(>J)A��O�Q8�̫�~-�����8!���0v2��O o��<قM 	�}P9T �El�h�ydy}^^մG`���Md�#:k�B��Y����\r��F4��f-�%Tm��F:������9�j��a<�g    r����i��	vH��D�0��nE7���[��>~�C���:9g���1ӄ�_���L��b)v>�k%q�)�I��C�O;tr�V�s�G�t+�a0��d2�$oҘ�Vr�-�\��<�^�j%/�@jw�H,4���V2Ck����V0GbhEz�:v��d	Yk�R��g�B}@Of��a���.	���g�Gm'������1O���|�������W�y-�C1���X���z���/˄�ot�q�v�IϚB�\��Z��TQyV����˶ϝ;�֔�r3R��	�d9,@
ў���R!<Ĭ�˭Ȍ�]?㿧�q�e����Y��9�H��]��Z�����Y�8l\�̂�l�����)�c�7{������M]�]��I`[�+%�Y3�g�R��g�Yj&s�ڤ��co�4Чv�����?�����y�#��>���'	?FUX�M�S�@��,i	���'�	'��Uhw.�ﺂ��
�	u#�/{�(�{�G���E���	��i�2<��hF�B�dP!zyҳ�Y~��Z�ڡ��|�.�zz����g�ݲN�UF�OχW��������	���zF�K�-�o��x�69x��H��l|��3���C2���4ڙ�u�-��S4� �ָY�M~m)�ڮ����������8��7A`���6�3���W�_V� ;g�p*bx�q�C/X��y�D�	�����t@����
����O��	n��L�5x�jz��v^<:zhL��3z�6�$�����Ͻb�:��d�!0CH���{�O�=rR	��~�y�/h�����&G��嗯N��Ϭ1�ۂ�����یk�q���04��ـ:��1l�3�����Ǖ������8?���;�0?��s:�F���znC�tr�
�����ñ�Up�W�ˆa�����N'��1&���E�+��6`8!�p�`�v��N,���}���y3�t�1����aЈ������l��޹�Y��Һ% lە s�
��R�Q��,ݍ��u��	��㴿6��ʂLl�x�f<�,�ρ��Zf3[谌G6����f�+k8Z,Ɔ��pt��Nj��/lbv3����#�B��s!�s�`xjG	t<�w�b
C�t7)W9���� N'��5��ö����n�w�~o��2��������ҙ���ڒ�l�Lܼ�b�4@�=�0�s/;���E_N�>&�c.��>����6YL[�.�^}�~�K��/_���ӽ�q�Z�pYƊD����vE̺�NIhS�	;�,������S�{��@���slaaE���"i�
Ĺ�m��*�hE�Z
V��"�m4�*��⯚`C�^hw؀����xL��;��2=o<����>���ɿ}$,�&��3��p��5�/CrbF��9���0�LG���8�u��.����n�F��c�n��5���>d܎�w�axWy��J:�
N��;�zݻ�Ѳ4�Uc��lq�9����A�ǌ�+�-T@�޴tL���0�itvg��M�`k�{���EnBihe�F��ҫ�%�Vfm�O�����w��ܥ�_��܋��L-|7����h��~4'����ߋ�'�m���@G���>f���$��
�m�-����.����O���7���1|�rǮֺ�/�J��a��ѻ�}�RHpvJ5ɷw�3�@w﫴��[�7���n�r��1���u� �zs��O�QLH�([7�n�yt|�Q:�� �xDm���љM�P���-Lv��c]�"�|���h�w�c(�^�D��8�D�VR�E+�b#Tl�v�������P����C�*�����{�1��ݾ6o�@��ׯ�L�սzy��8cI�z�'�қ��*��Vru��V�����-�2�&u���A����#?�<J�D:��*w|"0Mt��7�taC�cu���c���"��~�U:D,�.�{��m:�c��_�#�j�[�Ic����c��������K��5���O�/|�g��}�y�Ͷ��'aL���7��Z�b�8.5��B���p;9oa�$� j��� �n����~A.r�,��$u%r� ��%�o��K�<���=7ˣ���J|Y8�M-�^@+���ع�C�A�ܗ��:�Qqc�¤o��C��
[����p}���ԃ<���X�i5=�>I�O�Β����Ե���V-�(���$ER�b�"yh3M�=6���7�&*ҧ63ٳ��6S;Y����*c���@��i�	�t�r�b	�ՔEz�hǆ����l,�������ܐ=�����쳀=h���J ��c��ҝj� 7���%4����A:�!U�"@�t|C��&�!��݀$����b|��r�S]�(��F����@�]Hz����D9d�(��fW���A���A�u�[	W�(��7�O��p�`�Z�t*,ahG��d��R��
������sP���`��sH����KGU�m�*����I�r��O�U$N-�*����n�~l��%����l�&�"����Hl��%��ޗ%4����J�K�����X~#�/ئkW��&�"[����z�d��NLjPg�VL������v��}�w.>�Y���r9�8�g�*�������>�t���|���ҧ�r���쩺%P�K
� ��+>uI?��spϼP�ұD�OG���Nz��ո����o����W]`ہr�OG8���[/�ܘ�l��U�i�؏R�m��a?y�k�9��׷�@�Uc�E��|���!�B�q�!'G_�U�vt>,�Q�]+��� ��ƽ�$sr5�C �Qp���r/1�����ߩ���i.��+�ܷ��򌁖}����i}�2df�L�*��۱���{f�E�m�J�V>bPu*��>,�ܫ��Aa����e#0�px/����B^A��H��Թ�,z��;)z��ۗ!�.~���>�	�w
��EG��+��솀�t�?�����t�z�}Dz^�NrԭoɷB�u�������%D�f�/�gG	&���u㭀����k߭h����G}������YB�;�":w��t�D4ӹ��L�Nz�Ν�f:wЧF:w���ɾR�οu��s�ӻ[ OR��Q�TΨ�����?�Ƃ�pBm-H�|�C8���EN�o���M%v?��s`�`���Ǭ,r�% ���x��+Ɛ�3	�d�������O�.��T�����%#�a~����..����Q�2tl�Kpp��<�opfx�];�ꂍC��Θ9�\�L�����2�,�L���JӡS"L������#?��I7�F�	��l�_�pP{��Oxe~�y�>��C����7 8��w�#���H�"L	a_�k7F_��h�¦0慉��,`#b^aB�"�X¨�y'#��O���1�p%<F���mBu�$ٽ�(I�F��K��( H&���OO�82%w��`9���b{�S0��o�fOz
�i��au�^�$g�F��U�~�9�ov�'�4�D��H;�iL+��<EW�^ٳ�GYf�y�.R����c���T��a����q�")�({�K���9:G%c��>�}��f&��<Gר�م��翅g�{�#��������1�da�(2���t�"O�1
DO\,���ǉ|��+Ɉˀ��E\��S	_$�"{���H%".��T�E�$q�9�G\�.HC'q��ZD\$�Y�H �"�oq�=���@�Ɂjql7P�o�TdORi��@E�"5P�6w��J~�"W�(;I��@E��b�"yl4Pn�TdO-*�g٥!�����%UO�����pP=aK-��Գg�_ ���]�~�H����,7M�^G��d�b�H�$�@$s�] ���--oA.]n�H�je)L�nf)L|/�x&n�&n:��+dlF����4=��'g
��N�5�(栍�/j=��"{	�(9��ټ�l��VE�
��{��Ú(�u�D��>��"��()���uz��FC�.�4� �J�ݧ�S�v�m	BV�:t��i"y$�p4Í\��"��֑��#XF>� cIC�2ҵ�c��W]�H5a�����:����k�,��� %  ,��u	�U�zt��%�Q�9��n�����������i����H�e�F�|��|�,],uE�H�$��hF8uE�O]e�E��ȒE�W$�&�Hɫ����/��-�.y��>r%��J�"�D��W	[H+��W�Z�1�3]�j"�.��hʘv�"��wF9�"���vm�_®HC�c?��)Ґw��Lˍ&��˨�'�P}6�u�,��"S8�E�`��Y4�Eb�\��r]��庈��uY� �>��9��&s*�Ó�m��n���m=�����w.nM�\�m�Q�<�|���W@� l��&p3�����5[M����Woi�L�|	:~��d�������+CB�������U���K�r:�>Z�ӛҁ���G\��|��ѩX�%L�G��;.1�1�m�?�sU;��8�ܧ�L���wP�S`��]�U$#+�`�.�P�_~�c�,)�S�����/���L�N�ԣaE��KxP���8}&pL�c@c�Jc�X�b��?��~e�B- �N�AP�b���"�b)�gJ'K�Q �
؏O�k_2�ఝ$�lZ�p���^�t���iGl����LD��6^��}r�����l�q숭�d��	c��E�ӿ��FTH�a�Bs��D{��!�W��)��ݙ���,ir�Y���ͷ�ef���؈��n�~�a�~ƍ��g�^.�u8�r+,���,F���z�}��铱Zh`N.iֳ��9�:��kk	��l%���/��Pp	4m��/_�c��!;��l�N�W���l�D��^g�q��76����ɰLO�R��`ʆ�ﶇ�Dם��<��f�j�?7d ��B'�����E�����<�HA\g��Ն�L�rxJ̘>��1�NƤ�<��:�?�mqb�o�<;�j�4qPa�S;�Z��5�1�c�4��+Ju&;���D�<���
��@f�>`&r�ۊ����1P琧��l���<�����ge�o�ɜ	<�[<�ꋂ9{����r�J�O�������s����9��K�It���Oonn�Oտ�     