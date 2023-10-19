/* eslint-disable */
import React from 'react';

const List = ({ columns, datas }) => {
    //console.log(datas)

    return (
        <div className='align-center'>
            {datas.map(data =>
                <tr key={data.id}>
                    {columns.map(column =>
                        <td className='align-middle' key={column.toLowerCase()}>{data[column.toString().toLowerCase()]}</td>
                    )
                    }
                    <td >
                        <button className='m-2 btn btn-primary'>Editar</button>
                        <button className='m-2 btn btn-danger'>Deletar</button>
                    </td>
                </tr>
            )
            }
        </div>
    );
}

export { List }