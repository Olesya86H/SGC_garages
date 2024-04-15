update t_sum ts
set id_type_garage = s.id_garage_type
from (
	select distinct tg.id_garage_type, tg.fio, tg.num
	from t_garages tg, t_sum t
	where t.id_account = '29'
	and t.num = tg.num
	and t.fio = tg.fio
	)s
where ts.id_account = '29'
and ts.num = s.num
and ts.fio = s.fio

--select * from t_sum where id_type_garage is null