import React from 'react';
import { render, screen } from '@testing-library/react';
import '@testing-library/jest-dom/extend-expect';
import Alert-dialog from './Alert-dialog';

describe('<Alert-dialog />', () => {
  test('it should mount', () => {
    render(<Alert-dialog />);
    
    const alertDialog = screen.getByTestId('Alert-dialog');

    expect(alertDialog).toBeInTheDocument();
  });
});