/* eslint-disable */
import React from 'react';

const List = ({ columns, datas }) => {
    //console.log(datas)

    return (
        <div>
            <table className='table table-striped' aria-labelledby="tabelLabel">
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
                                <td key={column.toLowerCase() }>{data[column.toString().toLowerCase()]}</td>
                            )
                            }
                            <td>
                                <button>Editar</button>
                            </td>
                            <td>
                                <button>Deletar</button>
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