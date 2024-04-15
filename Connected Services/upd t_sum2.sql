update t_sum ts
set id_type_garage = s.id_type_garage
from (
	select distinct tg.id_type_garage, tg.fio, tg.num
	from t_sum tg, t_sum t
	where t.id_account = '29'
	and t.num = tg.num
	and t.fio = tg.fio
	and t.id_type_garage is null
	and tg.id_account != '29'
	)s
where ts.id_account = '29'
and ts.num = s.num
and ts.fio = s.fio
and ts.id_type_garage is null

--select * from t_sum where id_type_garage is null