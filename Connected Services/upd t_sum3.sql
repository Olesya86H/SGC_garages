update t_sum ts
set id_garage = s.id_garage
from (
	select t1.id_garage, t1.fio, t1.num, t1.id_garage_type 
	from t_garages t1
)s
where ts.id_garage is null
and ts.fio = s.fio
and ts.num = s.num
and ts.id_type_garage = s.id_garage_type

--select * from t_sum where id_garage is null and id_type_garage = 4
--select * from t_garages where UPPER(fio) like UPPER('%Ержанов%')