import React from 'react';
import { ThemeProvider as MuiThemeProvider } from '@mui/styles';

import theme from './theme';

// eslint-disable-next-line react/prop-types
const ThemeProvider = ({ children }) => (
  <MuiThemeProvider theme={theme}>
    {children}
  </MuiThemeProvider>
);

export default ThemeProvider;