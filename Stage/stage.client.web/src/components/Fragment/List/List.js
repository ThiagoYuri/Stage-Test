/* eslint-disable */
import React from 'react';

const List = ({ columns, datas, event}) => {
    //console.log(datas)

    return (
        <div>
            <table className='table table-striped align-center' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        {
                            columns.map(column =>
                                <th key={column}>{column}</th>
                            )
                        }
                    </tr>
                </thead>
                <tbody>
                    { datas.map(data => 
                        
                        <tr key={data.id}>
                            {columns.map(column =>
                                <td className='align-middle align-center' key={column.toLowerCase() }>{data[column.toString().toLowerCase()]}</td>
                            )
                            }
                            <td className='align-end'>
                                <button className='m-2 btn btn-primary'>Detalhe</button>
                                <button className='m-2 btn btn-primary'>Editar</button>
                                <button className='m-2 btn btn-danger'>Deletar</button>
                            </td>                            
                        </tr>
                        
                    ) 
                    }
                </tbody>
            </table>
        </div>
    );
}

export { List }