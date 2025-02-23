-- Restreindre les ligne

select * from EMP where (job <> 'CLERK' and deptno = 20) or ename = 'TURNER';

select * from EMP where (sal >= 1000 and sal < 3000 and deptno =10) or 30;

select * from EMP where (sal BETWEEN 1000 and 3000 and deptno =10) or 30;

select * from EMP where deptno = 10 or DEPTNO =30 or DEPTNO =20;

select * from EMP where DEPTNO in (10,20);

select * from EMP where DEPTNO <> 30 and DEPTNO <>20;

select * from EMP where  DEPTNO not in (20,30);

select * from EMP where JOB like '_a%';

select * from EMP where JOB like'%m%';

select * from EMP where comm is null;

-- ou inclusif
select * from EMP where sal >= 1000 or job = 'CLERK' or ename = 'TURNER';

-- ou exclusif
select * from EMP where sal >= 1000 xor job = 'CLERK' xor ename = 'TURNER';
select * from EMP ;